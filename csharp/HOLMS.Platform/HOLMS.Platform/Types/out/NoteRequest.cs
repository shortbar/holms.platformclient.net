// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: operations/note_requests/note_request.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HOLMS.Types.Operations.NoteRequests {

  /// <summary>Holder for reflection information generated from operations/note_requests/note_request.proto</summary>
  public static partial class NoteRequestReflection {

    #region Descriptor
    /// <summary>File descriptor for operations/note_requests/note_request.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static NoteRequestReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CitvcGVyYXRpb25zL25vdGVfcmVxdWVzdHMvbm90ZV9yZXF1ZXN0LnByb3Rv",
            "EiRob2xtcy50eXBlcy5vcGVyYXRpb25zLm5vdGVfcmVxdWVzdHMaNW9wZXJh",
            "dGlvbnMvbm90ZV9yZXF1ZXN0cy9ub3RlX3JlcXVlc3RfaW5kaWNhdG9yLnBy",
            "b3RvGixvcGVyYXRpb25zL25vdGVfcmVxdWVzdHMvbm90ZV9jYXRlZ29yeS5w",
            "cm90bxoob3BlcmF0aW9ucy9ub3RlX3JlcXVlc3RzL25vdGVfdHlwZS5wcm90",
            "byKWAgoLTm90ZVJlcXVlc3QSTQoJZW50aXR5X2lkGAEgASgLMjouaG9sbXMu",
            "dHlwZXMub3BlcmF0aW9ucy5ub3RlX3JlcXVlc3RzLk5vdGVSZXF1ZXN0SW5k",
            "aWNhdG9yEg8KB3N1YmplY3QYAiABKAkSRgoKZGVwYXJ0bWVudBgDIAEoDjIy",
            "LmhvbG1zLnR5cGVzLm9wZXJhdGlvbnMubm90ZV9yZXF1ZXN0cy5Ob3RlQ2F0",
            "ZWdvcnkSQQoJbm90ZV90eXBlGAQgASgOMi4uaG9sbXMudHlwZXMub3BlcmF0",
            "aW9ucy5ub3RlX3JlcXVlc3RzLk5vdGVUeXBlEhwKFGF2YWlsYWJsZV9vbl93",
            "ZWJzaXRlGAUgASgIQj9aF29wZXJhdGlvbnMvbm90ZXJlcXVlc3RzqgIjSE9M",
            "TVMuVHlwZXMuT3BlcmF0aW9ucy5Ob3RlUmVxdWVzdHNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::HOLMS.Types.Operations.NoteRequests.NoteRequestIndicatorReflection.Descriptor, global::HOLMS.Types.Operations.NoteRequests.NoteCategoryReflection.Descriptor, global::HOLMS.Types.Operations.NoteRequests.NoteTypeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Operations.NoteRequests.NoteRequest), global::HOLMS.Types.Operations.NoteRequests.NoteRequest.Parser, new[]{ "EntityId", "Subject", "Department", "NoteType", "AvailableOnWebsite" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class NoteRequest : pb::IMessage<NoteRequest> {
    private static readonly pb::MessageParser<NoteRequest> _parser = new pb::MessageParser<NoteRequest>(() => new NoteRequest());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<NoteRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Operations.NoteRequests.NoteRequestReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public NoteRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public NoteRequest(NoteRequest other) : this() {
      EntityId = other.entityId_ != null ? other.EntityId.Clone() : null;
      subject_ = other.subject_;
      department_ = other.department_;
      noteType_ = other.noteType_;
      availableOnWebsite_ = other.availableOnWebsite_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public NoteRequest Clone() {
      return new NoteRequest(this);
    }

    /// <summary>Field number for the "entity_id" field.</summary>
    public const int EntityIdFieldNumber = 1;
    private global::HOLMS.Types.Operations.NoteRequests.NoteRequestIndicator entityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Operations.NoteRequests.NoteRequestIndicator EntityId {
      get { return entityId_; }
      set {
        entityId_ = value;
      }
    }

    /// <summary>Field number for the "subject" field.</summary>
    public const int SubjectFieldNumber = 2;
    private string subject_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Subject {
      get { return subject_; }
      set {
        subject_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "department" field.</summary>
    public const int DepartmentFieldNumber = 3;
    private global::HOLMS.Types.Operations.NoteRequests.NoteCategory department_ = 0;
    /// <summary>
    ///  TODO(DA) Change this to department indicator, later
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Operations.NoteRequests.NoteCategory Department {
      get { return department_; }
      set {
        department_ = value;
      }
    }

    /// <summary>Field number for the "note_type" field.</summary>
    public const int NoteTypeFieldNumber = 4;
    private global::HOLMS.Types.Operations.NoteRequests.NoteType noteType_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Operations.NoteRequests.NoteType NoteType {
      get { return noteType_; }
      set {
        noteType_ = value;
      }
    }

    /// <summary>Field number for the "available_on_website" field.</summary>
    public const int AvailableOnWebsiteFieldNumber = 5;
    private bool availableOnWebsite_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool AvailableOnWebsite {
      get { return availableOnWebsite_; }
      set {
        availableOnWebsite_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as NoteRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(NoteRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(EntityId, other.EntityId)) return false;
      if (Subject != other.Subject) return false;
      if (Department != other.Department) return false;
      if (NoteType != other.NoteType) return false;
      if (AvailableOnWebsite != other.AvailableOnWebsite) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (entityId_ != null) hash ^= EntityId.GetHashCode();
      if (Subject.Length != 0) hash ^= Subject.GetHashCode();
      if (Department != 0) hash ^= Department.GetHashCode();
      if (NoteType != 0) hash ^= NoteType.GetHashCode();
      if (AvailableOnWebsite != false) hash ^= AvailableOnWebsite.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (entityId_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(EntityId);
      }
      if (Subject.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Subject);
      }
      if (Department != 0) {
        output.WriteRawTag(24);
        output.WriteEnum((int) Department);
      }
      if (NoteType != 0) {
        output.WriteRawTag(32);
        output.WriteEnum((int) NoteType);
      }
      if (AvailableOnWebsite != false) {
        output.WriteRawTag(40);
        output.WriteBool(AvailableOnWebsite);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (entityId_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(EntityId);
      }
      if (Subject.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Subject);
      }
      if (Department != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Department);
      }
      if (NoteType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) NoteType);
      }
      if (AvailableOnWebsite != false) {
        size += 1 + 1;
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(NoteRequest other) {
      if (other == null) {
        return;
      }
      if (other.entityId_ != null) {
        if (entityId_ == null) {
          entityId_ = new global::HOLMS.Types.Operations.NoteRequests.NoteRequestIndicator();
        }
        EntityId.MergeFrom(other.EntityId);
      }
      if (other.Subject.Length != 0) {
        Subject = other.Subject;
      }
      if (other.Department != 0) {
        Department = other.Department;
      }
      if (other.NoteType != 0) {
        NoteType = other.NoteType;
      }
      if (other.AvailableOnWebsite != false) {
        AvailableOnWebsite = other.AvailableOnWebsite;
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
            if (entityId_ == null) {
              entityId_ = new global::HOLMS.Types.Operations.NoteRequests.NoteRequestIndicator();
            }
            input.ReadMessage(entityId_);
            break;
          }
          case 18: {
            Subject = input.ReadString();
            break;
          }
          case 24: {
            department_ = (global::HOLMS.Types.Operations.NoteRequests.NoteCategory) input.ReadEnum();
            break;
          }
          case 32: {
            noteType_ = (global::HOLMS.Types.Operations.NoteRequests.NoteType) input.ReadEnum();
            break;
          }
          case 40: {
            AvailableOnWebsite = input.ReadBool();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
