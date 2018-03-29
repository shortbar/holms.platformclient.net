// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: primitive/interval.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HOLMS.Types.Primitive {

  /// <summary>Holder for reflection information generated from primitive/interval.proto</summary>
  public static partial class IntervalReflection {

    #region Descriptor
    /// <summary>File descriptor for primitive/interval.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static IntervalReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChhwcmltaXRpdmUvaW50ZXJ2YWwucHJvdG8SFWhvbG1zLnR5cGVzLnByaW1p",
            "dGl2ZRofZ29vZ2xlL3Byb3RvYnVmL3RpbWVzdGFtcC5wcm90byJeCghJbnRl",
            "cnZhbBIpCgVzdGFydBgBIAEoCzIaLmdvb2dsZS5wcm90b2J1Zi5UaW1lc3Rh",
            "bXASJwoDZW5kGAIgASgLMhouZ29vZ2xlLnByb3RvYnVmLlRpbWVzdGFtcEIY",
            "qgIVSE9MTVMuVHlwZXMuUHJpbWl0aXZlYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Primitive.Interval), global::HOLMS.Types.Primitive.Interval.Parser, new[]{ "Start", "End" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Interval : pb::IMessage<Interval> {
    private static readonly pb::MessageParser<Interval> _parser = new pb::MessageParser<Interval>(() => new Interval());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Interval> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Primitive.IntervalReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Interval() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Interval(Interval other) : this() {
      Start = other.start_ != null ? other.Start.Clone() : null;
      End = other.end_ != null ? other.End.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Interval Clone() {
      return new Interval(this);
    }

    /// <summary>Field number for the "start" field.</summary>
    public const int StartFieldNumber = 1;
    private global::Google.Protobuf.WellKnownTypes.Timestamp start_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Timestamp Start {
      get { return start_; }
      set {
        start_ = value;
      }
    }

    /// <summary>Field number for the "end" field.</summary>
    public const int EndFieldNumber = 2;
    private global::Google.Protobuf.WellKnownTypes.Timestamp end_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Timestamp End {
      get { return end_; }
      set {
        end_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Interval);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Interval other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Start, other.Start)) return false;
      if (!object.Equals(End, other.End)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (start_ != null) hash ^= Start.GetHashCode();
      if (end_ != null) hash ^= End.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (start_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Start);
      }
      if (end_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(End);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (start_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Start);
      }
      if (end_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(End);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Interval other) {
      if (other == null) {
        return;
      }
      if (other.start_ != null) {
        if (start_ == null) {
          start_ = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        Start.MergeFrom(other.Start);
      }
      if (other.end_ != null) {
        if (end_ == null) {
          end_ = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        End.MergeFrom(other.End);
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
            if (start_ == null) {
              start_ = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(start_);
            break;
          }
          case 18: {
            if (end_ == null) {
              end_ = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(end_);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
