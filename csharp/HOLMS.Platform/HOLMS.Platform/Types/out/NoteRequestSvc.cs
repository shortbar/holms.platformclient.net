// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: operations/rpc/note_request_svc.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HOLMS.Types.Operations.RPC {

  /// <summary>Holder for reflection information generated from operations/rpc/note_request_svc.proto</summary>
  public static partial class NoteRequestSvcReflection {

    #region Descriptor
    /// <summary>File descriptor for operations/rpc/note_request_svc.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static NoteRequestSvcReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiVvcGVyYXRpb25zL3JwYy9ub3RlX3JlcXVlc3Rfc3ZjLnByb3RvEhpob2xt",
            "cy50eXBlcy5vcGVyYXRpb25zLnJwYxoqcHJpbWl0aXZlL3NlcnZlcl9hY3Rp",
            "b25fY29uZmlybWF0aW9uLnByb3RvGhtnb29nbGUvcHJvdG9idWYvZW1wdHku",
            "cHJvdG8aNW9wZXJhdGlvbnMvbm90ZV9yZXF1ZXN0cy9ub3RlX3JlcXVlc3Rf",
            "aW5kaWNhdG9yLnByb3RvGitvcGVyYXRpb25zL25vdGVfcmVxdWVzdHMvbm90",
            "ZV9yZXF1ZXN0LnByb3RvImUKGU5vdGVSZXF1ZXN0U3ZjQWxsUmVzcG9uc2US",
            "SAoNbm90ZV9yZXF1ZXN0cxgBIAMoCzIxLmhvbG1zLnR5cGVzLm9wZXJhdGlv",
            "bnMubm90ZV9yZXF1ZXN0cy5Ob3RlUmVxdWVzdDKuBAoOTm90ZVJlcXVlc3RT",
            "dmMSVAoDQWxsEhYuZ29vZ2xlLnByb3RvYnVmLkVtcHR5GjUuaG9sbXMudHlw",
            "ZXMub3BlcmF0aW9ucy5ycGMuTm90ZVJlcXVlc3RTdmNBbGxSZXNwb25zZRJ4",
            "CgdHZXRCeUlkEjouaG9sbXMudHlwZXMub3BlcmF0aW9ucy5ub3RlX3JlcXVl",
            "c3RzLk5vdGVSZXF1ZXN0SW5kaWNhdG9yGjEuaG9sbXMudHlwZXMub3BlcmF0",
            "aW9ucy5ub3RlX3JlcXVlc3RzLk5vdGVSZXF1ZXN0Em4KBkNyZWF0ZRIxLmhv",
            "bG1zLnR5cGVzLm9wZXJhdGlvbnMubm90ZV9yZXF1ZXN0cy5Ob3RlUmVxdWVz",
            "dBoxLmhvbG1zLnR5cGVzLm9wZXJhdGlvbnMubm90ZV9yZXF1ZXN0cy5Ob3Rl",
            "UmVxdWVzdBJuCgZVcGRhdGUSMS5ob2xtcy50eXBlcy5vcGVyYXRpb25zLm5v",
            "dGVfcmVxdWVzdHMuTm90ZVJlcXVlc3QaMS5ob2xtcy50eXBlcy5vcGVyYXRp",
            "b25zLm5vdGVfcmVxdWVzdHMuTm90ZVJlcXVlc3QSbAoGRGVsZXRlEjEuaG9s",
            "bXMudHlwZXMub3BlcmF0aW9ucy5ub3RlX3JlcXVlc3RzLk5vdGVSZXF1ZXN0",
            "Gi8uaG9sbXMudHlwZXMucHJpbWl0aXZlLlNlcnZlckFjdGlvbkNvbmZpcm1h",
            "dGlvbkItWg5vcGVyYXRpb25zL3JwY6oCGkhPTE1TLlR5cGVzLk9wZXJhdGlv",
            "bnMuUlBDYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::HOLMS.Types.Primitive.ServerActionConfirmationReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.EmptyReflection.Descriptor, global::HOLMS.Types.Operations.NoteRequests.NoteRequestIndicatorReflection.Descriptor, global::HOLMS.Types.Operations.NoteRequests.NoteRequestReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Operations.RPC.NoteRequestSvcAllResponse), global::HOLMS.Types.Operations.RPC.NoteRequestSvcAllResponse.Parser, new[]{ "NoteRequests" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class NoteRequestSvcAllResponse : pb::IMessage<NoteRequestSvcAllResponse> {
    private static readonly pb::MessageParser<NoteRequestSvcAllResponse> _parser = new pb::MessageParser<NoteRequestSvcAllResponse>(() => new NoteRequestSvcAllResponse());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<NoteRequestSvcAllResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Operations.RPC.NoteRequestSvcReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public NoteRequestSvcAllResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public NoteRequestSvcAllResponse(NoteRequestSvcAllResponse other) : this() {
      noteRequests_ = other.noteRequests_.Clone();
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public NoteRequestSvcAllResponse Clone() {
      return new NoteRequestSvcAllResponse(this);
    }

    /// <summary>Field number for the "note_requests" field.</summary>
    public const int NoteRequestsFieldNumber = 1;
    private static readonly pb::FieldCodec<global::HOLMS.Types.Operations.NoteRequests.NoteRequest> _repeated_noteRequests_codec
        = pb::FieldCodec.ForMessage(10, global::HOLMS.Types.Operations.NoteRequests.NoteRequest.Parser);
    private readonly pbc::RepeatedField<global::HOLMS.Types.Operations.NoteRequests.NoteRequest> noteRequests_ = new pbc::RepeatedField<global::HOLMS.Types.Operations.NoteRequests.NoteRequest>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::HOLMS.Types.Operations.NoteRequests.NoteRequest> NoteRequests {
      get { return noteRequests_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as NoteRequestSvcAllResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(NoteRequestSvcAllResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!noteRequests_.Equals(other.noteRequests_)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= noteRequests_.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      noteRequests_.WriteTo(output, _repeated_noteRequests_codec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += noteRequests_.CalculateSize(_repeated_noteRequests_codec);
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(NoteRequestSvcAllResponse other) {
      if (other == null) {
        return;
      }
      noteRequests_.Add(other.noteRequests_);
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
            noteRequests_.AddEntriesFrom(input, _repeated_noteRequests_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
