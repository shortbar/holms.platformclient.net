// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: booking/indicators/turn_away_reason_indicator.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HOLMS.Types.Booking.Indicators {

  /// <summary>Holder for reflection information generated from booking/indicators/turn_away_reason_indicator.proto</summary>
  public static partial class TurnAwayReasonIndicatorReflection {

    #region Descriptor
    /// <summary>File descriptor for booking/indicators/turn_away_reason_indicator.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TurnAwayReasonIndicatorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjNib29raW5nL2luZGljYXRvcnMvdHVybl9hd2F5X3JlYXNvbl9pbmRpY2F0",
            "b3IucHJvdG8SHmhvbG1zLnR5cGVzLmJvb2tpbmcuaW5kaWNhdG9ycxoUcHJp",
            "bWl0aXZlL3V1aWQucHJvdG8iQgoXVHVybkF3YXlSZWFzb25JbmRpY2F0b3IS",
            "JwoCaWQYASABKAsyGy5ob2xtcy50eXBlcy5wcmltaXRpdmUuVXVpZEI1WhJi",
            "b29raW5nL2luZGljYXRvcnOqAh5IT0xNUy5UeXBlcy5Cb29raW5nLkluZGlj",
            "YXRvcnNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::HOLMS.Types.Primitive.UuidReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Booking.Indicators.TurnAwayReasonIndicator), global::HOLMS.Types.Booking.Indicators.TurnAwayReasonIndicator.Parser, new[]{ "Id" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class TurnAwayReasonIndicator : pb::IMessage<TurnAwayReasonIndicator> {
    private static readonly pb::MessageParser<TurnAwayReasonIndicator> _parser = new pb::MessageParser<TurnAwayReasonIndicator>(() => new TurnAwayReasonIndicator());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<TurnAwayReasonIndicator> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Booking.Indicators.TurnAwayReasonIndicatorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TurnAwayReasonIndicator() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TurnAwayReasonIndicator(TurnAwayReasonIndicator other) : this() {
      Id = other.id_ != null ? other.Id.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TurnAwayReasonIndicator Clone() {
      return new TurnAwayReasonIndicator(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private global::HOLMS.Types.Primitive.Uuid id_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Primitive.Uuid Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as TurnAwayReasonIndicator);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(TurnAwayReasonIndicator other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Id, other.Id)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (id_ != null) hash ^= Id.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (id_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Id);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (id_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Id);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(TurnAwayReasonIndicator other) {
      if (other == null) {
        return;
      }
      if (other.id_ != null) {
        if (id_ == null) {
          id_ = new global::HOLMS.Types.Primitive.Uuid();
        }
        Id.MergeFrom(other.Id);
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
          case 10: {
            if (id_ == null) {
              id_ = new global::HOLMS.Types.Primitive.Uuid();
            }
            input.ReadMessage(id_);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
