// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: crm/guests/reservation_note_template_indicator.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HOLMS.Types.CRM.Guests {

  /// <summary>Holder for reflection information generated from crm/guests/reservation_note_template_indicator.proto</summary>
  public static partial class ReservationNoteTemplateIndicatorReflection {

    #region Descriptor
    /// <summary>File descriptor for crm/guests/reservation_note_template_indicator.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ReservationNoteTemplateIndicatorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjRjcm0vZ3Vlc3RzL3Jlc2VydmF0aW9uX25vdGVfdGVtcGxhdGVfaW5kaWNh",
            "dG9yLnByb3RvEhZob2xtcy50eXBlcy5jcm0uZ3Vlc3RzGhRwcmltaXRpdmUv",
            "dXVpZC5wcm90byJLCiBSZXNlcnZhdGlvbk5vdGVUZW1wbGF0ZUluZGljYXRv",
            "chInCgJpZBgBIAEoCzIbLmhvbG1zLnR5cGVzLnByaW1pdGl2ZS5VdWlkQhmq",
            "AhZIT0xNUy5UeXBlcy5DUk0uR3Vlc3RzYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::HOLMS.Types.Primitive.UuidReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.CRM.Guests.ReservationNoteTemplateIndicator), global::HOLMS.Types.CRM.Guests.ReservationNoteTemplateIndicator.Parser, new[]{ "Id" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ReservationNoteTemplateIndicator : pb::IMessage<ReservationNoteTemplateIndicator> {
    private static readonly pb::MessageParser<ReservationNoteTemplateIndicator> _parser = new pb::MessageParser<ReservationNoteTemplateIndicator>(() => new ReservationNoteTemplateIndicator());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ReservationNoteTemplateIndicator> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.CRM.Guests.ReservationNoteTemplateIndicatorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ReservationNoteTemplateIndicator() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ReservationNoteTemplateIndicator(ReservationNoteTemplateIndicator other) : this() {
      Id = other.id_ != null ? other.Id.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ReservationNoteTemplateIndicator Clone() {
      return new ReservationNoteTemplateIndicator(this);
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
      return Equals(other as ReservationNoteTemplateIndicator);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ReservationNoteTemplateIndicator other) {
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
    public void MergeFrom(ReservationNoteTemplateIndicator other) {
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
