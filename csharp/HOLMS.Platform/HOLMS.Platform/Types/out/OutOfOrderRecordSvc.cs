// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: operations/rpc/out_of_order_record_svc.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HOLMS.Types.Operations.RPC {

  /// <summary>Holder for reflection information generated from operations/rpc/out_of_order_record_svc.proto</summary>
  public static partial class OutOfOrderRecordSvcReflection {

    #region Descriptor
    /// <summary>File descriptor for operations/rpc/out_of_order_record_svc.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static OutOfOrderRecordSvcReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CixvcGVyYXRpb25zL3JwYy9vdXRfb2Zfb3JkZXJfcmVjb3JkX3N2Yy5wcm90",
            "bxIaaG9sbXMudHlwZXMub3BlcmF0aW9ucy5ycGMaMW9wZXJhdGlvbnMvb3V0",
            "X29mX29yZGVyL291dF9vZl9vcmRlcl9yZWNvcmQucHJvdG8aO29wZXJhdGlv",
            "bnMvb3V0X29mX29yZGVyL291dF9vZl9vcmRlcl9yZWNvcmRfaW5kaWNhdG9y",
            "LnByb3RvGjJ0ZW5hbmN5X2NvbmZpZy9pbmRpY2F0b3JzL3Byb3BlcnR5X2lu",
            "ZGljYXRvci5wcm90byJoCh5PdXRPZk9yZGVyUmVjb3JkU3ZjQWxsUmVzcG9u",
            "c2USRgoHcmVjb3JkcxgBIAMoCzI1LmhvbG1zLnR5cGVzLm9wZXJhdGlvbnMu",
            "b3V0X29mX29yZGVyLk91dE9mT3JkZXJSZWNvcmQiswEKH091dE9mT3JkZXJS",
            "ZWNvcmRHZXRCeUlkUmVzcG9uc2USSQoGcmVzdWx0GAEgASgOMjkuaG9sbXMu",
            "dHlwZXMub3BlcmF0aW9ucy5ycGMuT3V0T2ZPcmRlclJlY29yZEdldEJ5SWRS",
            "ZXN1bHQSRQoGcmVjb3JkGAIgASgLMjUuaG9sbXMudHlwZXMub3BlcmF0aW9u",
            "cy5vdXRfb2Zfb3JkZXIuT3V0T2ZPcmRlclJlY29yZCKxAQoeT3V0T2ZPcmRl",
            "clJlY29yZENyZWF0ZVJlc3BvbnNlEkgKBnJlc3VsdBgBIAEoDjI4LmhvbG1z",
            "LnR5cGVzLm9wZXJhdGlvbnMucnBjLk91dE9mT3JkZXJSZWNvcmRDcmVhdGVS",
            "ZXN1bHQSRQoGcmVjb3JkGAIgASgLMjUuaG9sbXMudHlwZXMub3BlcmF0aW9u",
            "cy5vdXRfb2Zfb3JkZXIuT3V0T2ZPcmRlclJlY29yZCKxAQoeT3V0T2ZPcmRl",
            "clJlY29yZFVwZGF0ZVJlc3BvbnNlEkgKBnJlc3VsdBgBIAEoDjI4LmhvbG1z",
            "LnR5cGVzLm9wZXJhdGlvbnMucnBjLk91dE9mT3JkZXJSZWNvcmRVcGRhdGVS",
            "ZXN1bHQSRQoGcmVjb3JkGAIgASgLMjUuaG9sbXMudHlwZXMub3BlcmF0aW9u",
            "cy5vdXRfb2Zfb3JkZXIuT3V0T2ZPcmRlclJlY29yZCJqCh5PdXRPZk9yZGVy",
            "UmVjb3JkRGVsZXRlUmVzcG9uc2USSAoGcmVzdWx0GAEgASgOMjguaG9sbXMu",
            "dHlwZXMub3BlcmF0aW9ucy5ycGMuT3V0T2ZPcmRlclJlY29yZERlbGV0ZVJl",
            "c3VsdCphCh1PdXRPZk9yZGVyUmVjb3JkR2V0QnlJZFJlc3VsdBIdChlPVVRf",
            "T0ZfT1JERVJfUkVDT1JEX0ZPVU5EEAASIQodT1VUX09GX09SREVSX1JFQ09S",
            "RF9OT1RfRk9VTkQQASq2AgocT3V0T2ZPcmRlclJlY29yZENyZWF0ZVJlc3Vs",
            "dBImCiJPVVRfT0ZfT1JERVJfUkVDT1JEX0NSRUFURV9TVUNDRVNTEAASLQop",
            "T1VUX09GX09SREVSX1JFQ09SRF9DUkVBVEVfTUFJTlRfQ09ORkxJQ1QQARIz",
            "Ci9PVVRfT0ZfT1JERVJfUkVDT1JEX0NSRUFURV9SRVNFUlZBVElPTl9DT05G",
            "TElDVBACEi0KKU9VVF9PRl9PUkRFUl9SRUNPUkRfQ1JFQVRFX1JPT01fTk9U",
            "X0ZPVU5EEAMSKAokT1VUX09GX09SREVSX1JFQ09SRF9DUkVBVEVfTk9fU1VQ",
            "UExZEAQSMQotT1VUX09GX09SREVSX1JFQ09SRF9DUkVBVEVfT0NDVVBBTkNZ",
            "X0NPTkZMSUNUEAUq7wIKHE91dE9mT3JkZXJSZWNvcmRVcGRhdGVSZXN1bHQS",
            "KQolT1VUX09GX09SREVSX1JFQ09SRF9VUERBVEVfU1VDQ0VTU0ZVTBAAEi4K",
            "Kk9VVF9PRl9PUkRFUl9SRUNPUkRfVVBEQVRFX1BSSU9SX05PVF9GT1VORBAB",
            "Ei0KKU9VVF9PRl9PUkRFUl9SRUNPUkRfVVBEQVRFX01BSU5UX0NPTkZMSUNU",
            "EAISMwovT1VUX09GX09SREVSX1JFQ09SRF9VUERBVEVfUkVTRVJWQVRJT05f",
            "Q09ORkxJQ1QQAxItCilPVVRfT0ZfT1JERVJfUkVDT1JEX1VQREFURV9ST09N",
            "X05PVF9GT1VORBAEEi4KKk9VVF9PRl9PUkRFUl9SRUNPUkRfVVBEQVRFX05P",
            "X0FWQUlMQUJJTElUWRAFEjEKLU9VVF9PRl9PUkRFUl9SRUNPUkRfVVBEQVRF",
            "X09DQ1VQQU5DWV9DT05GTElDVBAGKnkKHE91dE9mT3JkZXJSZWNvcmREZWxl",
            "dGVSZXN1bHQSKQolT1VUX09GX09SREVSX1JFQ09SRF9ERUxFVEVfU1VDQ0VT",
            "U0ZVTBAAEi4KKk9VVF9PRl9PUkRFUl9SRUNPUkRfREVMRVRFX1BSSU9SX05P",
            "VF9GT1VORBABMpwFChNPdXRPZk9yZGVyUmVjb3JkU3ZjEnsKA0FsbBI4Lmhv",
            "bG1zLnR5cGVzLnRlbmFuY3lfY29uZmlnLmluZGljYXRvcnMuUHJvcGVydHlJ",
            "bmRpY2F0b3IaOi5ob2xtcy50eXBlcy5vcGVyYXRpb25zLnJwYy5PdXRPZk9y",
            "ZGVyUmVjb3JkU3ZjQWxsUmVzcG9uc2UShgEKB0dldEJ5SWQSPi5ob2xtcy50",
            "eXBlcy5vcGVyYXRpb25zLm91dF9vZl9vcmRlci5PdXRPZk9yZGVyUmVjb3Jk",
            "SW5kaWNhdG9yGjsuaG9sbXMudHlwZXMub3BlcmF0aW9ucy5ycGMuT3V0T2ZP",
            "cmRlclJlY29yZEdldEJ5SWRSZXNwb25zZRJ7CgZDcmVhdGUSNS5ob2xtcy50",
            "eXBlcy5vcGVyYXRpb25zLm91dF9vZl9vcmRlci5PdXRPZk9yZGVyUmVjb3Jk",
            "GjouaG9sbXMudHlwZXMub3BlcmF0aW9ucy5ycGMuT3V0T2ZPcmRlclJlY29y",
            "ZENyZWF0ZVJlc3BvbnNlEnsKBlVwZGF0ZRI1LmhvbG1zLnR5cGVzLm9wZXJh",
            "dGlvbnMub3V0X29mX29yZGVyLk91dE9mT3JkZXJSZWNvcmQaOi5ob2xtcy50",
            "eXBlcy5vcGVyYXRpb25zLnJwYy5PdXRPZk9yZGVyUmVjb3JkVXBkYXRlUmVz",
            "cG9uc2UShAEKBkRlbGV0ZRI+LmhvbG1zLnR5cGVzLm9wZXJhdGlvbnMub3V0",
            "X29mX29yZGVyLk91dE9mT3JkZXJSZWNvcmRJbmRpY2F0b3IaOi5ob2xtcy50",
            "eXBlcy5vcGVyYXRpb25zLnJwYy5PdXRPZk9yZGVyUmVjb3JkRGVsZXRlUmVz",
            "cG9uc2VCLVoOb3BlcmF0aW9ucy9ycGOqAhpIT0xNUy5UeXBlcy5PcGVyYXRp",
            "b25zLlJQQ2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::HOLMS.Types.Operations.OutOfOrder.OutOfOrderRecordReflection.Descriptor, global::HOLMS.Types.Operations.OutOfOrder.OutOfOrderRecordIndicatorReflection.Descriptor, global::HOLMS.Types.TenancyConfig.Indicators.PropertyIndicatorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::HOLMS.Types.Operations.RPC.OutOfOrderRecordGetByIdResult), typeof(global::HOLMS.Types.Operations.RPC.OutOfOrderRecordCreateResult), typeof(global::HOLMS.Types.Operations.RPC.OutOfOrderRecordUpdateResult), typeof(global::HOLMS.Types.Operations.RPC.OutOfOrderRecordDeleteResult), }, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Operations.RPC.OutOfOrderRecordSvcAllResponse), global::HOLMS.Types.Operations.RPC.OutOfOrderRecordSvcAllResponse.Parser, new[]{ "Records" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Operations.RPC.OutOfOrderRecordGetByIdResponse), global::HOLMS.Types.Operations.RPC.OutOfOrderRecordGetByIdResponse.Parser, new[]{ "Result", "Record" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Operations.RPC.OutOfOrderRecordCreateResponse), global::HOLMS.Types.Operations.RPC.OutOfOrderRecordCreateResponse.Parser, new[]{ "Result", "Record" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Operations.RPC.OutOfOrderRecordUpdateResponse), global::HOLMS.Types.Operations.RPC.OutOfOrderRecordUpdateResponse.Parser, new[]{ "Result", "Record" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Operations.RPC.OutOfOrderRecordDeleteResponse), global::HOLMS.Types.Operations.RPC.OutOfOrderRecordDeleteResponse.Parser, new[]{ "Result" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Enums
  public enum OutOfOrderRecordGetByIdResult {
    [pbr::OriginalName("OUT_OF_ORDER_RECORD_FOUND")] OutOfOrderRecordFound = 0,
    [pbr::OriginalName("OUT_OF_ORDER_RECORD_NOT_FOUND")] OutOfOrderRecordNotFound = 1,
  }

  public enum OutOfOrderRecordCreateResult {
    [pbr::OriginalName("OUT_OF_ORDER_RECORD_CREATE_SUCCESS")] OutOfOrderRecordCreateSuccess = 0,
    [pbr::OriginalName("OUT_OF_ORDER_RECORD_CREATE_MAINT_CONFLICT")] OutOfOrderRecordCreateMaintConflict = 1,
    [pbr::OriginalName("OUT_OF_ORDER_RECORD_CREATE_RESERVATION_CONFLICT")] OutOfOrderRecordCreateReservationConflict = 2,
    [pbr::OriginalName("OUT_OF_ORDER_RECORD_CREATE_ROOM_NOT_FOUND")] OutOfOrderRecordCreateRoomNotFound = 3,
    [pbr::OriginalName("OUT_OF_ORDER_RECORD_CREATE_NO_SUPPLY")] OutOfOrderRecordCreateNoSupply = 4,
    [pbr::OriginalName("OUT_OF_ORDER_RECORD_CREATE_OCCUPANCY_CONFLICT")] OutOfOrderRecordCreateOccupancyConflict = 5,
  }

  public enum OutOfOrderRecordUpdateResult {
    [pbr::OriginalName("OUT_OF_ORDER_RECORD_UPDATE_SUCCESSFUL")] OutOfOrderRecordUpdateSuccessful = 0,
    [pbr::OriginalName("OUT_OF_ORDER_RECORD_UPDATE_PRIOR_NOT_FOUND")] OutOfOrderRecordUpdatePriorNotFound = 1,
    [pbr::OriginalName("OUT_OF_ORDER_RECORD_UPDATE_MAINT_CONFLICT")] OutOfOrderRecordUpdateMaintConflict = 2,
    [pbr::OriginalName("OUT_OF_ORDER_RECORD_UPDATE_RESERVATION_CONFLICT")] OutOfOrderRecordUpdateReservationConflict = 3,
    [pbr::OriginalName("OUT_OF_ORDER_RECORD_UPDATE_ROOM_NOT_FOUND")] OutOfOrderRecordUpdateRoomNotFound = 4,
    [pbr::OriginalName("OUT_OF_ORDER_RECORD_UPDATE_NO_AVAILABILITY")] OutOfOrderRecordUpdateNoAvailability = 5,
    [pbr::OriginalName("OUT_OF_ORDER_RECORD_UPDATE_OCCUPANCY_CONFLICT")] OutOfOrderRecordUpdateOccupancyConflict = 6,
  }

  public enum OutOfOrderRecordDeleteResult {
    [pbr::OriginalName("OUT_OF_ORDER_RECORD_DELETE_SUCCESSFUL")] OutOfOrderRecordDeleteSuccessful = 0,
    [pbr::OriginalName("OUT_OF_ORDER_RECORD_DELETE_PRIOR_NOT_FOUND")] OutOfOrderRecordDeletePriorNotFound = 1,
  }

  #endregion

  #region Messages
  public sealed partial class OutOfOrderRecordSvcAllResponse : pb::IMessage<OutOfOrderRecordSvcAllResponse> {
    private static readonly pb::MessageParser<OutOfOrderRecordSvcAllResponse> _parser = new pb::MessageParser<OutOfOrderRecordSvcAllResponse>(() => new OutOfOrderRecordSvcAllResponse());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<OutOfOrderRecordSvcAllResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Operations.RPC.OutOfOrderRecordSvcReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public OutOfOrderRecordSvcAllResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public OutOfOrderRecordSvcAllResponse(OutOfOrderRecordSvcAllResponse other) : this() {
      records_ = other.records_.Clone();
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public OutOfOrderRecordSvcAllResponse Clone() {
      return new OutOfOrderRecordSvcAllResponse(this);
    }

    /// <summary>Field number for the "records" field.</summary>
    public const int RecordsFieldNumber = 1;
    private static readonly pb::FieldCodec<global::HOLMS.Types.Operations.OutOfOrder.OutOfOrderRecord> _repeated_records_codec
        = pb::FieldCodec.ForMessage(10, global::HOLMS.Types.Operations.OutOfOrder.OutOfOrderRecord.Parser);
    private readonly pbc::RepeatedField<global::HOLMS.Types.Operations.OutOfOrder.OutOfOrderRecord> records_ = new pbc::RepeatedField<global::HOLMS.Types.Operations.OutOfOrder.OutOfOrderRecord>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::HOLMS.Types.Operations.OutOfOrder.OutOfOrderRecord> Records {
      get { return records_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as OutOfOrderRecordSvcAllResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(OutOfOrderRecordSvcAllResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!records_.Equals(other.records_)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= records_.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      records_.WriteTo(output, _repeated_records_codec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += records_.CalculateSize(_repeated_records_codec);
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(OutOfOrderRecordSvcAllResponse other) {
      if (other == null) {
        return;
      }
      records_.Add(other.records_);
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
            records_.AddEntriesFrom(input, _repeated_records_codec);
            break;
          }
        }
      }
    }

  }

  public sealed partial class OutOfOrderRecordGetByIdResponse : pb::IMessage<OutOfOrderRecordGetByIdResponse> {
    private static readonly pb::MessageParser<OutOfOrderRecordGetByIdResponse> _parser = new pb::MessageParser<OutOfOrderRecordGetByIdResponse>(() => new OutOfOrderRecordGetByIdResponse());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<OutOfOrderRecordGetByIdResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Operations.RPC.OutOfOrderRecordSvcReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public OutOfOrderRecordGetByIdResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public OutOfOrderRecordGetByIdResponse(OutOfOrderRecordGetByIdResponse other) : this() {
      result_ = other.result_;
      Record = other.record_ != null ? other.Record.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public OutOfOrderRecordGetByIdResponse Clone() {
      return new OutOfOrderRecordGetByIdResponse(this);
    }

    /// <summary>Field number for the "result" field.</summary>
    public const int ResultFieldNumber = 1;
    private global::HOLMS.Types.Operations.RPC.OutOfOrderRecordGetByIdResult result_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Operations.RPC.OutOfOrderRecordGetByIdResult Result {
      get { return result_; }
      set {
        result_ = value;
      }
    }

    /// <summary>Field number for the "record" field.</summary>
    public const int RecordFieldNumber = 2;
    private global::HOLMS.Types.Operations.OutOfOrder.OutOfOrderRecord record_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Operations.OutOfOrder.OutOfOrderRecord Record {
      get { return record_; }
      set {
        record_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as OutOfOrderRecordGetByIdResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(OutOfOrderRecordGetByIdResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Result != other.Result) return false;
      if (!object.Equals(Record, other.Record)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Result != 0) hash ^= Result.GetHashCode();
      if (record_ != null) hash ^= Record.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Result != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Result);
      }
      if (record_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Record);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Result != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Result);
      }
      if (record_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Record);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(OutOfOrderRecordGetByIdResponse other) {
      if (other == null) {
        return;
      }
      if (other.Result != 0) {
        Result = other.Result;
      }
      if (other.record_ != null) {
        if (record_ == null) {
          record_ = new global::HOLMS.Types.Operations.OutOfOrder.OutOfOrderRecord();
        }
        Record.MergeFrom(other.Record);
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
            result_ = (global::HOLMS.Types.Operations.RPC.OutOfOrderRecordGetByIdResult) input.ReadEnum();
            break;
          }
          case 18: {
            if (record_ == null) {
              record_ = new global::HOLMS.Types.Operations.OutOfOrder.OutOfOrderRecord();
            }
            input.ReadMessage(record_);
            break;
          }
        }
      }
    }

  }

  public sealed partial class OutOfOrderRecordCreateResponse : pb::IMessage<OutOfOrderRecordCreateResponse> {
    private static readonly pb::MessageParser<OutOfOrderRecordCreateResponse> _parser = new pb::MessageParser<OutOfOrderRecordCreateResponse>(() => new OutOfOrderRecordCreateResponse());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<OutOfOrderRecordCreateResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Operations.RPC.OutOfOrderRecordSvcReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public OutOfOrderRecordCreateResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public OutOfOrderRecordCreateResponse(OutOfOrderRecordCreateResponse other) : this() {
      result_ = other.result_;
      Record = other.record_ != null ? other.Record.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public OutOfOrderRecordCreateResponse Clone() {
      return new OutOfOrderRecordCreateResponse(this);
    }

    /// <summary>Field number for the "result" field.</summary>
    public const int ResultFieldNumber = 1;
    private global::HOLMS.Types.Operations.RPC.OutOfOrderRecordCreateResult result_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Operations.RPC.OutOfOrderRecordCreateResult Result {
      get { return result_; }
      set {
        result_ = value;
      }
    }

    /// <summary>Field number for the "record" field.</summary>
    public const int RecordFieldNumber = 2;
    private global::HOLMS.Types.Operations.OutOfOrder.OutOfOrderRecord record_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Operations.OutOfOrder.OutOfOrderRecord Record {
      get { return record_; }
      set {
        record_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as OutOfOrderRecordCreateResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(OutOfOrderRecordCreateResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Result != other.Result) return false;
      if (!object.Equals(Record, other.Record)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Result != 0) hash ^= Result.GetHashCode();
      if (record_ != null) hash ^= Record.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Result != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Result);
      }
      if (record_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Record);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Result != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Result);
      }
      if (record_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Record);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(OutOfOrderRecordCreateResponse other) {
      if (other == null) {
        return;
      }
      if (other.Result != 0) {
        Result = other.Result;
      }
      if (other.record_ != null) {
        if (record_ == null) {
          record_ = new global::HOLMS.Types.Operations.OutOfOrder.OutOfOrderRecord();
        }
        Record.MergeFrom(other.Record);
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
            result_ = (global::HOLMS.Types.Operations.RPC.OutOfOrderRecordCreateResult) input.ReadEnum();
            break;
          }
          case 18: {
            if (record_ == null) {
              record_ = new global::HOLMS.Types.Operations.OutOfOrder.OutOfOrderRecord();
            }
            input.ReadMessage(record_);
            break;
          }
        }
      }
    }

  }

  public sealed partial class OutOfOrderRecordUpdateResponse : pb::IMessage<OutOfOrderRecordUpdateResponse> {
    private static readonly pb::MessageParser<OutOfOrderRecordUpdateResponse> _parser = new pb::MessageParser<OutOfOrderRecordUpdateResponse>(() => new OutOfOrderRecordUpdateResponse());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<OutOfOrderRecordUpdateResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Operations.RPC.OutOfOrderRecordSvcReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public OutOfOrderRecordUpdateResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public OutOfOrderRecordUpdateResponse(OutOfOrderRecordUpdateResponse other) : this() {
      result_ = other.result_;
      Record = other.record_ != null ? other.Record.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public OutOfOrderRecordUpdateResponse Clone() {
      return new OutOfOrderRecordUpdateResponse(this);
    }

    /// <summary>Field number for the "result" field.</summary>
    public const int ResultFieldNumber = 1;
    private global::HOLMS.Types.Operations.RPC.OutOfOrderRecordUpdateResult result_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Operations.RPC.OutOfOrderRecordUpdateResult Result {
      get { return result_; }
      set {
        result_ = value;
      }
    }

    /// <summary>Field number for the "record" field.</summary>
    public const int RecordFieldNumber = 2;
    private global::HOLMS.Types.Operations.OutOfOrder.OutOfOrderRecord record_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Operations.OutOfOrder.OutOfOrderRecord Record {
      get { return record_; }
      set {
        record_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as OutOfOrderRecordUpdateResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(OutOfOrderRecordUpdateResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Result != other.Result) return false;
      if (!object.Equals(Record, other.Record)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Result != 0) hash ^= Result.GetHashCode();
      if (record_ != null) hash ^= Record.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Result != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Result);
      }
      if (record_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Record);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Result != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Result);
      }
      if (record_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Record);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(OutOfOrderRecordUpdateResponse other) {
      if (other == null) {
        return;
      }
      if (other.Result != 0) {
        Result = other.Result;
      }
      if (other.record_ != null) {
        if (record_ == null) {
          record_ = new global::HOLMS.Types.Operations.OutOfOrder.OutOfOrderRecord();
        }
        Record.MergeFrom(other.Record);
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
            result_ = (global::HOLMS.Types.Operations.RPC.OutOfOrderRecordUpdateResult) input.ReadEnum();
            break;
          }
          case 18: {
            if (record_ == null) {
              record_ = new global::HOLMS.Types.Operations.OutOfOrder.OutOfOrderRecord();
            }
            input.ReadMessage(record_);
            break;
          }
        }
      }
    }

  }

  public sealed partial class OutOfOrderRecordDeleteResponse : pb::IMessage<OutOfOrderRecordDeleteResponse> {
    private static readonly pb::MessageParser<OutOfOrderRecordDeleteResponse> _parser = new pb::MessageParser<OutOfOrderRecordDeleteResponse>(() => new OutOfOrderRecordDeleteResponse());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<OutOfOrderRecordDeleteResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Operations.RPC.OutOfOrderRecordSvcReflection.Descriptor.MessageTypes[4]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public OutOfOrderRecordDeleteResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public OutOfOrderRecordDeleteResponse(OutOfOrderRecordDeleteResponse other) : this() {
      result_ = other.result_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public OutOfOrderRecordDeleteResponse Clone() {
      return new OutOfOrderRecordDeleteResponse(this);
    }

    /// <summary>Field number for the "result" field.</summary>
    public const int ResultFieldNumber = 1;
    private global::HOLMS.Types.Operations.RPC.OutOfOrderRecordDeleteResult result_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Operations.RPC.OutOfOrderRecordDeleteResult Result {
      get { return result_; }
      set {
        result_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as OutOfOrderRecordDeleteResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(OutOfOrderRecordDeleteResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Result != other.Result) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Result != 0) hash ^= Result.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Result != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Result);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Result != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Result);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(OutOfOrderRecordDeleteResponse other) {
      if (other == null) {
        return;
      }
      if (other.Result != 0) {
        Result = other.Result;
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
            result_ = (global::HOLMS.Types.Operations.RPC.OutOfOrderRecordDeleteResult) input.ReadEnum();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
