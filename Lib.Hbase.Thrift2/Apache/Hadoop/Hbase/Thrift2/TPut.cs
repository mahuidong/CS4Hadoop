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
  public partial class TPut : TBase
  {
    private byte[] _row;
    private List<TColumnValue> _columnValues;
    private long _timestamp;
    private bool _writeToWal;

    public byte[] Row
    {
      get
      {
        return _row;
      }
      set
      {
        __isset.row = true;
        this._row = value;
      }
    }

    public List<TColumnValue> ColumnValues
    {
      get
      {
        return _columnValues;
      }
      set
      {
        __isset.columnValues = true;
        this._columnValues = value;
      }
    }

    public long Timestamp
    {
      get
      {
        return _timestamp;
      }
      set
      {
        __isset.timestamp = true;
        this._timestamp = value;
      }
    }

    public bool WriteToWal
    {
      get
      {
        return _writeToWal;
      }
      set
      {
        __isset.writeToWal = true;
        this._writeToWal = value;
      }
    }


    public Isset __isset;
    [Serializable]
    public struct Isset {
      public bool row;
      public bool columnValues;
      public bool timestamp;
      public bool writeToWal;
    }

    public TPut() {
      this._writeToWal = true;
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
              Row = iprot.ReadBinary();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.List) {
              {
                ColumnValues = new List<TColumnValue>();
                TList _list8 = iprot.ReadListBegin();
                for( int _i9 = 0; _i9 < _list8.Count; ++_i9)
                {
                  TColumnValue _elem10 = new TColumnValue();
                  _elem10 = new TColumnValue();
                  _elem10.Read(iprot);
                  ColumnValues.Add(_elem10);
                }
                iprot.ReadListEnd();
              }
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.I64) {
              Timestamp = iprot.ReadI64();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 4:
            if (field.Type == TType.Bool) {
              WriteToWal = iprot.ReadBool();
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
      TStruct struc = new TStruct("TPut");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (Row != null && __isset.row) {
        field.Name = "row";
        field.Type = TType.String;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteBinary(Row);
        oprot.WriteFieldEnd();
      }
      if (ColumnValues != null && __isset.columnValues) {
        field.Name = "columnValues";
        field.Type = TType.List;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.Struct, ColumnValues.Count));
          foreach (TColumnValue _iter11 in ColumnValues)
          {
            _iter11.Write(oprot);
          }
          oprot.WriteListEnd();
        }
        oprot.WriteFieldEnd();
      }
      if (__isset.timestamp) {
        field.Name = "timestamp";
        field.Type = TType.I64;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        oprot.WriteI64(Timestamp);
        oprot.WriteFieldEnd();
      }
      if (__isset.writeToWal) {
        field.Name = "writeToWal";
        field.Type = TType.Bool;
        field.ID = 4;
        oprot.WriteFieldBegin(field);
        oprot.WriteBool(WriteToWal);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("TPut(");
      sb.Append("Row: ");
      sb.Append(Row);
      sb.Append(",ColumnValues: ");
      sb.Append(ColumnValues);
      sb.Append(",Timestamp: ");
      sb.Append(Timestamp);
      sb.Append(",WriteToWal: ");
      sb.Append(WriteToWal);
      sb.Append(")");
      return sb.ToString();
    }

  }

}