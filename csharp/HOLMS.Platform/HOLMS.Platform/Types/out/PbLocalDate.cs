// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: primitive/pb_local_date.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HOLMS.Types.Primitive {

  /// <summary>Holder for reflection information generated from primitive/pb_local_date.proto</summary>
  public static partial class PbLocalDateReflection {

    #region Descriptor
    /// <summary>File descriptor for primitive/pb_local_date.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PbLocalDateReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch1wcmltaXRpdmUvcGJfbG9jYWxfZGF0ZS5wcm90bxIVaG9sbXMudHlwZXMu",
            "cHJpbWl0aXZlIjcKC1BiTG9jYWxEYXRlEgwKBHllYXIYASABKA0SDQoFbW9u",
            "dGgYAiABKA0SCwoDZGF5GAMgASgNQiNaCXByaW1pdGl2ZaoCFUhPTE1TLlR5",
            "cGVzLlByaW1pdGl2ZWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Primitive.PbLocalDate), global::HOLMS.Types.Primitive.PbLocalDate.Parser, new[]{ "Year", "Month", "Day" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class PbLocalDate : pb::IMessage<PbLocalDate> {
    private static readonly pb::MessageParser<PbLocalDate> _parser = new pb::MessageParser<PbLocalDate>(() => new PbLocalDate());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PbLocalDate> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Primitive.PbLocalDateReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PbLocalDate() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PbLocalDate(PbLocalDate other) : this() {
      year_ = other.year_;
      month_ = other.month_;
      day_ = other.day_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PbLocalDate Clone() {
      return new PbLocalDate(this);
    }

    /// <summary>Field number for the "year" field.</summary>
    public const int YearFieldNumber = 1;
    private uint year_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint Year {
      get { return year_; }
      set {
        year_ = value;
      }
    }

    /// <summary>Field number for the "month" field.</summary>
    public const int MonthFieldNumber = 2;
    private uint month_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint Month {
      get { return month_; }
      set {
        month_ = value;
      }
    }

    /// <summary>Field number for the "day" field.</summary>
    public const int DayFieldNumber = 3;
    private uint day_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint Day {
      get { return day_; }
      set {
        day_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PbLocalDate);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PbLocalDate other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Year != other.Year) return false;
      if (Month != other.Month) return false;
      if (Day != other.Day) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Year != 0) hash ^= Year.GetHashCode();
      if (Month != 0) hash ^= Month.GetHashCode();
      if (Day != 0) hash ^= Day.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Year != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(Year);
      }
      if (Month != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(Month);
      }
      if (Day != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(Day);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Year != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Year);
      }
      if (Month != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Month);
      }
      if (Day != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Day);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PbLocalDate other) {
      if (other == null) {
        return;
      }
      if (other.Year != 0) {
        Year = other.Year;
      }
      if (other.Month != 0) {
        Month = other.Month;
      }
      if (other.Day != 0) {
        Day = other.Day;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            Year = input.ReadUInt32();
            break;
          }
          case 16: {
            Month = input.ReadUInt32();
            break;
          }
          case 24: {
            Day = input.ReadUInt32();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
