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
  public partial class Order : TBase
  {
    private string _col;
    private int _order;

    public string Col
    {
      get
      {
        return _col;
      }
      set
      {
        __isset.col = true;
        this._col = value;
      }
    }

    public int order
    {
      get
      {
        return _order;
      }
      set
      {
        __isset.order = true;
        this._order = value;
      }
    }


    public Isset __isset;
    [Serializable]
    public struct Isset {
      public bool col;
      public bool order;
    }

    public Order() {
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
              Col = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.I32) {
              order = iprot.ReadI32();
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
      TStruct struc = new TStruct("Order");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (Col != null && __isset.col) {
        field.Name = "col";
        field.Type = TType.String;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(Col);
        oprot.WriteFieldEnd();
      }
      if (__isset.order) {
        field.Name = "order";
        field.Type = TType.I32;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(order);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("Order(");
      sb.Append("Col: ");
      sb.Append(Col);
      sb.Append(",Order: ");
      sb.Append(order);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
