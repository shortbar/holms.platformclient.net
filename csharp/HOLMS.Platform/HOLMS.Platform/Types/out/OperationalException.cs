// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: opex_logging/operational_exception.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HOLMS.Types.OpExLogging {

  /// <summary>Holder for reflection information generated from opex_logging/operational_exception.proto</summary>
  public static partial class OperationalExceptionReflection {

    #region Descriptor
    /// <summary>File descriptor for opex_logging/operational_exception.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static OperationalExceptionReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CihvcGV4X2xvZ2dpbmcvb3BlcmF0aW9uYWxfZXhjZXB0aW9uLnByb3RvEhho",
            "b2xtcy50eXBlcy5vcGV4X2xvZ2dpbmcaH2dvb2dsZS9wcm90b2J1Zi90aW1l",
            "c3RhbXAucHJvdG8idgoUT3BlcmF0aW9uYWxFeGNlcHRpb24SGQoRZXhjZXB0",
            "aW9uX21lc3NhZ2UYASABKAkSFAoMZXhjZXB0aW9uX2lkGAIgASgJEi0KCXRp",
            "bWVzdGFtcBgDIAEoCzIaLmdvb2dsZS5wcm90b2J1Zi5UaW1lc3RhbXBCGqoC",
            "F0hPTE1TLlR5cGVzLk9wRXhMb2dnaW5nYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.OpExLogging.OperationalException), global::HOLMS.Types.OpExLogging.OperationalException.Parser, new[]{ "ExceptionMessage", "ExceptionId", "Timestamp" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class OperationalException : pb::IMessage<OperationalException> {
    private static readonly pb::MessageParser<OperationalException> _parser = new pb::MessageParser<OperationalException>(() => new OperationalException());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<OperationalException> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.OpExLogging.OperationalExceptionReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public OperationalException() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public OperationalException(OperationalException other) : this() {
      exceptionMessage_ = other.exceptionMessage_;
      exceptionId_ = other.exceptionId_;
      Timestamp = other.timestamp_ != null ? other.Timestamp.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public OperationalException Clone() {
      return new OperationalException(this);
    }

    /// <summary>Field number for the "exception_message" field.</summary>
    public const int ExceptionMessageFieldNumber = 1;
    private string exceptionMessage_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ExceptionMessage {
      get { return exceptionMessage_; }
      set {
        exceptionMessage_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "exception_id" field.</summary>
    public const int ExceptionIdFieldNumber = 2;
    private string exceptionId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ExceptionId {
      get { return exceptionId_; }
      set {
        exceptionId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "timestamp" field.</summary>
    public const int TimestampFieldNumber = 3;
    private global::Google.Protobuf.WellKnownTypes.Timestamp timestamp_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Timestamp Timestamp {
      get { return timestamp_; }
      set {
        timestamp_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as OperationalException);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(OperationalException other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ExceptionMessage != other.ExceptionMessage) return false;
      if (ExceptionId != other.ExceptionId) return false;
      if (!object.Equals(Timestamp, other.Timestamp)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ExceptionMessage.Length != 0) hash ^= ExceptionMessage.GetHashCode();
      if (ExceptionId.Length != 0) hash ^= ExceptionId.GetHashCode();
      if (timestamp_ != null) hash ^= Timestamp.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (ExceptionMessage.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ExceptionMessage);
      }
      if (ExceptionId.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(ExceptionId);
      }
      if (timestamp_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Timestamp);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ExceptionMessage.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ExceptionMessage);
      }
      if (ExceptionId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ExceptionId);
      }
      if (timestamp_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Timestamp);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(OperationalException other) {
      if (other == null) {
        return;
      }
      if (other.ExceptionMessage.Length != 0) {
        ExceptionMessage = other.ExceptionMessage;
      }
      if (other.ExceptionId.Length != 0) {
        ExceptionId = other.ExceptionId;
      }
      if (other.timestamp_ != null) {
        if (timestamp_ == null) {
          timestamp_ = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        Timestamp.MergeFrom(other.Timestamp);
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
            ExceptionMessage = input.ReadString();
            break;
          }
          case 18: {
            ExceptionId = input.ReadString();
            break;
          }
          case 26: {
            if (timestamp_ == null) {
              timestamp_ = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(timestamp_);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
