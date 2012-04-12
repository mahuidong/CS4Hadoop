/**
 * Autogenerated by Thrift Compiler (0.7.0)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Thrift;
using Thrift.Collections;
using Thrift.Protocol;
using Thrift.Transport;
namespace Apache.Hadoop.Hive
{

  [Serializable]
  public partial class Adjacency : TBase
  {
    private string _node;
    private List<string> _children;
    private AdjacencyType _adjacencyType;

    public string Node
    {
      get
      {
        return _node;
      }
      set
      {
        __isset.node = true;
        this._node = value;
      }
    }

    public List<string> Children
    {
      get
      {
        return _children;
      }
      set
      {
        __isset.children = true;
        this._children = value;
      }
    }

    public AdjacencyType AdjacencyType
    {
      get
      {
        return _adjacencyType;
      }
      set
      {
        __isset.adjacencyType = true;
        this._adjacencyType = value;
      }
    }


    public Isset __isset;
    [Serializable]
    public struct Isset {
      public bool node;
      public bool children;
      public bool adjacencyType;
    }

    public Adjacency() {
    }

    public void Read (TProtocol iprot)
    {
      TField field;
      iprot.ReadStructBegin();
      while (true)
      {
        field = iprot.ReadFieldBegin();
        if (field.Type == TType.Stop) { 
          break;
        }
        switch (field.ID)
        {
          case 1:
            if (field.Type == TType.String) {
              Node = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.List) {
              {
                Children = new List<string>();
                TList _list0 = iprot.ReadListBegin();
                for( int _i1 = 0; _i1 < _list0.Count; ++_i1)
                {
                  string _elem2 = null;
                  _elem2 = iprot.ReadString();
                  Children.Add(_elem2);
                }
                iprot.ReadListEnd();
              }
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.I32) {
              AdjacencyType = (AdjacencyType)iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          default: 
            TProtocolUtil.Skip(iprot, field.Type);
            break;
        }
        iprot.ReadFieldEnd();
      }
      iprot.ReadStructEnd();
    }

    public void Write(TProtocol oprot) {
      TStruct struc = new TStruct("Adjacency");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (Node != null && __isset.node) {
        field.Name = "node";
        field.Type = TType.String;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(Node);
        oprot.WriteFieldEnd();
      }
      if (Children != null && __isset.children) {
        field.Name = "children";
        field.Type = TType.List;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.String, Children.Count));
          foreach (string _iter3 in Children)
          {
            oprot.WriteString(_iter3);
          }
          oprot.WriteListEnd();
        }
        oprot.WriteFieldEnd();
      }
      if (__isset.adjacencyType) {
        field.Name = "adjacencyType";
        field.Type = TType.I32;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32((int)AdjacencyType);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("Adjacency(");
      sb.Append("Node: ");
      sb.Append(Node);
      sb.Append(",Children: ");
      sb.Append(Children);
      sb.Append(",AdjacencyType: ");
      sb.Append(AdjacencyType);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
