// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: supply/rate_schedule_indicator.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HOLMS.Types.Supply {

  /// <summary>Holder for reflection information generated from supply/rate_schedule_indicator.proto</summary>
  public static partial class RateScheduleIndicatorReflection {

    #region Descriptor
    /// <summary>File descriptor for supply/rate_schedule_indicator.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RateScheduleIndicatorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiRzdXBwbHkvcmF0ZV9zY2hlZHVsZV9pbmRpY2F0b3IucHJvdG8SEmhvbG1z",
            "LnR5cGVzLnN1cHBseRoUcHJpbWl0aXZlL3V1aWQucHJvdG8iQAoVUmF0ZVNj",
            "aGVkdWxlSW5kaWNhdG9yEicKAmlkGAEgASgLMhsuaG9sbXMudHlwZXMucHJp",
            "bWl0aXZlLlV1aWRCHVoGc3VwcGx5qgISSE9MTVMuVHlwZXMuU3VwcGx5YgZw",
            "cm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::HOLMS.Types.Primitive.UuidReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Supply.RateScheduleIndicator), global::HOLMS.Types.Supply.RateScheduleIndicator.Parser, new[]{ "Id" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class RateScheduleIndicator : pb::IMessage<RateScheduleIndicator> {
    private static readonly pb::MessageParser<RateScheduleIndicator> _parser = new pb::MessageParser<RateScheduleIndicator>(() => new RateScheduleIndicator());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<RateScheduleIndicator> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Supply.RateScheduleIndicatorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RateScheduleIndicator() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RateScheduleIndicator(RateScheduleIndicator other) : this() {
      Id = other.id_ != null ? other.Id.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RateScheduleIndicator Clone() {
      return new RateScheduleIndicator(this);
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
      return Equals(other as RateScheduleIndicator);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(RateScheduleIndicator other) {
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
    public void MergeFrom(RateScheduleIndicator other) {
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
