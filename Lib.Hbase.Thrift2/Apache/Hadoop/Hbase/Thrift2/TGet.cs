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
  public partial class TGet : TBase
  {
    private byte[] _row;
    private List<TColumn> _columns;
    private long _timestamp;
    private TTimeRange _timeRange;
    private int _maxVersions;

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

    public List<TColumn> Columns
    {
      get
      {
        return _columns;
      }
      set
      {
        __isset.columns = true;
        this._columns = value;
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

    public TTimeRange TimeRange
    {
      get
      {
        return _timeRange;
      }
      set
      {
        __isset.timeRange = true;
        this._timeRange = value;
      }
    }

    public int MaxVersions
    {
      get
      {
        return _maxVersions;
      }
      set
      {
        __isset.maxVersions = true;
        this._maxVersions = value;
      }
    }


    public Isset __isset;
    [Serializable]
    public struct Isset {
      public bool row;
      public bool columns;
      public bool timestamp;
      public bool timeRange;
      public bool maxVersions;
    }

    public TGet() {
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
                Columns = new List<TColumn>();
                TList _list4 = iprot.ReadListBegin();
                for( int _i5 = 0; _i5 < _list4.Count; ++_i5)
                {
                  TColumn _elem6 = new TColumn();
                  _elem6 = new TColumn();
                  _elem6.Read(iprot);
                  Columns.Add(_elem6);
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
            if (field.Type == TType.Struct) {
              TimeRange = new TTimeRange();
              TimeRange.Read(iprot);
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 5:
            if (field.Type == TType.I32) {
              MaxVersions = iprot.ReadI32();
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
      TStruct struc = new TStruct("TGet");
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
      if (Columns != null && __isset.columns) {
        field.Name = "columns";
        field.Type = TType.List;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.Struct, Columns.Count));
          foreach (TColumn _iter7 in Columns)
          {
            _iter7.Write(oprot);
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
      if (TimeRange != null && __isset.timeRange) {
        field.Name = "timeRange";
        field.Type = TType.Struct;
        field.ID = 4;
        oprot.WriteFieldBegin(field);
        TimeRange.Write(oprot);
        oprot.WriteFieldEnd();
      }
      if (__isset.maxVersions) {
        field.Name = "maxVersions";
        field.Type = TType.I32;
        field.ID = 5;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(MaxVersions);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("TGet(");
      sb.Append("Row: ");
      sb.Append(Row);
      sb.Append(",Columns: ");
      sb.Append(Columns);
      sb.Append(",Timestamp: ");
      sb.Append(Timestamp);
      sb.Append(",TimeRange: ");
      sb.Append(TimeRange== null ? "<null>" : TimeRange.ToString());
      sb.Append(",MaxVersions: ");
      sb.Append(MaxVersions);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
