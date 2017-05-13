// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: supply/snapshot/lodging_quantity_snapshot_request_response.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HOLMS.Types.Supply.Snapshot {

  /// <summary>Holder for reflection information generated from supply/snapshot/lodging_quantity_snapshot_request_response.proto</summary>
  public static partial class LodgingQuantitySnapshotRequestResponseReflection {

    #region Descriptor
    /// <summary>File descriptor for supply/snapshot/lodging_quantity_snapshot_request_response.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static LodgingQuantitySnapshotRequestResponseReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkBzdXBwbHkvc25hcHNob3QvbG9kZ2luZ19xdWFudGl0eV9zbmFwc2hvdF9y",
            "ZXF1ZXN0X3Jlc3BvbnNlLnByb3RvEhtob2xtcy50eXBlcy5zdXBwbHkuc25h",
            "cHNob3QaP3N1cHBseS9zbmFwc2hvdC9sb2RnaW5nX3F1YW50aXR5X3NuYXBz",
            "aG90X3Jlc3BvbnNlX3JlY29yZC5wcm90byJ+CiZMb2RnaW5nUXVhbnRpdHlT",
            "bmFwc2hvdFJlcXVlc3RSZXNwb25zZRJUCghyZXNwb25zZRgBIAMoCzJCLmhv",
            "bG1zLnR5cGVzLnN1cHBseS5zbmFwc2hvdC5Mb2RnaW5nUXVhbnRpdHlTbmFw",
            "c2hvdFJlc3BvbnNlUmVjb3JkQi9aD3N1cHBseS9zbmFwc2hvdKoCG0hPTE1T",
            "LlR5cGVzLlN1cHBseS5TbmFwc2hvdGIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::HOLMS.Types.Supply.Snapshot.LodgingQuantitySnapshotResponseRecordReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Supply.Snapshot.LodgingQuantitySnapshotRequestResponse), global::HOLMS.Types.Supply.Snapshot.LodgingQuantitySnapshotRequestResponse.Parser, new[]{ "Response" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class LodgingQuantitySnapshotRequestResponse : pb::IMessage<LodgingQuantitySnapshotRequestResponse> {
    private static readonly pb::MessageParser<LodgingQuantitySnapshotRequestResponse> _parser = new pb::MessageParser<LodgingQuantitySnapshotRequestResponse>(() => new LodgingQuantitySnapshotRequestResponse());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<LodgingQuantitySnapshotRequestResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Supply.Snapshot.LodgingQuantitySnapshotRequestResponseReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LodgingQuantitySnapshotRequestResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LodgingQuantitySnapshotRequestResponse(LodgingQuantitySnapshotRequestResponse other) : this() {
      response_ = other.response_.Clone();
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LodgingQuantitySnapshotRequestResponse Clone() {
      return new LodgingQuantitySnapshotRequestResponse(this);
    }

    /// <summary>Field number for the "response" field.</summary>
    public const int ResponseFieldNumber = 1;
    private static readonly pb::FieldCodec<global::HOLMS.Types.Supply.Snapshot.LodgingQuantitySnapshotResponseRecord> _repeated_response_codec
        = pb::FieldCodec.ForMessage(10, global::HOLMS.Types.Supply.Snapshot.LodgingQuantitySnapshotResponseRecord.Parser);
    private readonly pbc::RepeatedField<global::HOLMS.Types.Supply.Snapshot.LodgingQuantitySnapshotResponseRecord> response_ = new pbc::RepeatedField<global::HOLMS.Types.Supply.Snapshot.LodgingQuantitySnapshotResponseRecord>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::HOLMS.Types.Supply.Snapshot.LodgingQuantitySnapshotResponseRecord> Response {
      get { return response_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as LodgingQuantitySnapshotRequestResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(LodgingQuantitySnapshotRequestResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!response_.Equals(other.response_)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= response_.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      response_.WriteTo(output, _repeated_response_codec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += response_.CalculateSize(_repeated_response_codec);
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(LodgingQuantitySnapshotRequestResponse other) {
      if (other == null) {
        return;
      }
      response_.Add(other.response_);
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
            response_.AddEntriesFrom(input, _repeated_response_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code