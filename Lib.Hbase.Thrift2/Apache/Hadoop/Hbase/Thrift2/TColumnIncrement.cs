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
namespace Apache.Hadoop.Hbase.Thrift2
{

  [Serializable]
  public partial class TColumnIncrement : TBase
  {
    private byte[] _family;
    private byte[] _qualifier;
    private long _amount;

    public byte[] Family
    {
      get
      {
        return _family;
      }
      set
      {
        __isset.family = true;
        this._family = value;
      }
    }

    public byte[] Qualifier
    {
      get
      {
        return _qualifier;
      }
      set
      {
        __isset.qualifier = true;
        this._qualifier = value;
      }
    }

    public long Amount
    {
      get
      {
        return _amount;
      }
      set
      {
        __isset.amount = true;
        this._amount = value;
      }
    }


    public Isset __isset;
    [Serializable]
    public struct Isset {
      public bool family;
      public bool qualifier;
      public bool amount;
    }

    public TColumnIncrement() {
      this._amount = 1;
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
              Family = iprot.ReadBinary();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.String) {
              Qualifier = iprot.ReadBinary();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.I64) {
              Amount = iprot.ReadI64();
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
      TStruct struc = new TStruct("TColumnIncrement");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (Family != null && __isset.family) {
        field.Name = "family";
        field.Type = TType.String;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteBinary(Family);
        oprot.WriteFieldEnd();
      }
      if (Qualifier != null && __isset.qualifier) {
        field.Name = "qualifier";
        field.Type = TType.String;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteBinary(Qualifier);
        oprot.WriteFieldEnd();
      }
      if (__isset.amount) {
        field.Name = "amount";
        field.Type = TType.I64;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        oprot.WriteI64(Amount);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("TColumnIncrement(");
      sb.Append("Family: ");
      sb.Append(Family);
      sb.Append(",Qualifier: ");
      sb.Append(Qualifier);
      sb.Append(",Amount: ");
      sb.Append(Amount);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
