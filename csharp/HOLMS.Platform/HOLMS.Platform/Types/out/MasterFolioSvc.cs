// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: money/rpc/master_folio_svc.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HOLMS.Types.Money.RPC {

  /// <summary>Holder for reflection information generated from money/rpc/master_folio_svc.proto</summary>
  public static partial class MasterFolioSvcReflection {

    #region Descriptor
    /// <summary>File descriptor for money/rpc/master_folio_svc.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MasterFolioSvcReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiBtb25leS9ycGMvbWFzdGVyX2ZvbGlvX3N2Yy5wcm90bxIVaG9sbXMudHlw",
            "ZXMubW9uZXkucnBjGi5ib29raW5nL2luZGljYXRvcnMvcmVzZXJ2YXRpb25f",
            "aW5kaWNhdG9yLnByb3RvIoICCiRNYXN0ZXJGb2xpb1NlcnZpY2VNYXN0ZXJG",
            "b2xpb1JlcXVlc3QSSgoMY2xpZW50X2ZvbGlvGAEgASgLMjQuaG9sbXMudHlw",
            "ZXMuYm9va2luZy5pbmRpY2F0b3JzLlJlc2VydmF0aW9uSW5kaWNhdG9yEkoK",
            "DG1hc3Rlcl9mb2xpbxgCIAEoCzI0LmhvbG1zLnR5cGVzLmJvb2tpbmcuaW5k",
            "aWNhdG9ycy5SZXNlcnZhdGlvbkluZGljYXRvchIeChZtYXN0ZXJfYWNjcnVl",
            "c19sb2RnaW5nGAMgASgIEiIKGm1hc3Rlcl9hY2NydWVzX2luY2lkZW50YWxz",
            "GAQgASgIIoIBCixNYXN0ZXJGb2xpb1NlcnZpY2VSZXF1ZXN0TWFzdGVyRm9s",
            "aW9SZXNwb25zZRJSCgZyZXN1bHQYASABKA4yQi5ob2xtcy50eXBlcy5tb25l",
            "eS5ycGMuUmVzZXJ2YXRpb25Gb2xpb1N2Y1JlcXVlc3RNYXN0ZXJGb2xpb1Jl",
            "c3VsdCJ0CiZNYXN0ZXJGb2xpb1N2Y1JlbW92ZU1hc3RlckZvbGlvUmVxdWVz",
            "dBJKCgxjbGllbnRfZm9saW8YASABKAsyNC5ob2xtcy50eXBlcy5ib29raW5n",
            "LmluZGljYXRvcnMuUmVzZXJ2YXRpb25JbmRpY2F0b3IigAEKK01hc3RlckZv",
            "bGlvU2VydmljZVJlbW92ZU1hc3RlckZvbGlvUmVzcG9uc2USUQoGcmVzdWx0",
            "GAEgASgOMkEuaG9sbXMudHlwZXMubW9uZXkucnBjLlJlc2VydmF0aW9uRm9s",
            "aW9TdmNSZW1vdmVNYXN0ZXJGb2xpb1Jlc3VsdCqyAworUmVzZXJ2YXRpb25G",
            "b2xpb1N2Y1JlcXVlc3RNYXN0ZXJGb2xpb1Jlc3VsdBIsCihNQVNURVJfRk9M",
            "SU9fU1ZDX1JFUVVFU1RfTUFTVEVSX0ZPTElPX09LEAASOwo3TUFTVEVSX0ZP",
            "TElPX1NWQ19SRVFVRVNUX01BU1RFUl9GT0xJT19DTElFTlRfSEFTX01BU1RF",
            "UhABEjsKN01BU1RFUl9GT0xJT19TVkNfUkVRVUVTVF9NQVNURVJfRk9MSU9f",
            "TUFTVEVSX0hBU19NQVNURVIQAhIuCipNQVNURVJfRk9MSU9fU1ZDX1JFUVVF",
            "U1RfQ0xJRU5UX0hBU19DTElFTlQQAxI7CjdNQVNURVJfRk9MSU9fU1ZDX1JF",
            "UVVFU1RfTUFTVEVSX0ZPTElPX0RJU0FMTE9XRURfTUFTVEVSEAQSOwo3TUFT",
            "VEVSX0ZPTElPX1NWQ19SRVFVRVNUX01BU1RFUl9GT0xJT19ESVNBTExPV0VE",
            "X0NMSUVOVBAFEjEKLU1BU1RFUl9GT0xJT19TVkNfUkVRVUVTVF9NQVNURVJf",
            "Rk9MSU9fRkFJTFVSRRAGKr8BCipSZXNlcnZhdGlvbkZvbGlvU3ZjUmVtb3Zl",
            "TWFzdGVyRm9saW9SZXN1bHQSKwonTUFTVEVSX0ZPTElPX1NWQ19SRU1PVkVf",
            "TUFTVEVSX0ZPTElPX09LEAASMgouTUFTVEVSX0ZPTElPX1NWQ19SRU1PVkVf",
            "TUFTVEVSX0ZPTElPX05PX01BU1RFUhABEjAKLE1BU1RFUl9GT0xJT19TVkNf",
            "UkVNT1ZFX01BU1RFUl9GT0xJT19GQUlMVVJFEAIywgIKDk1hc3RlckZvbGlv",
            "U3ZjEpYBChJSZXF1ZXN0TWFzdGVyRm9saW8SOy5ob2xtcy50eXBlcy5tb25l",
            "eS5ycGMuTWFzdGVyRm9saW9TZXJ2aWNlTWFzdGVyRm9saW9SZXF1ZXN0GkMu",
            "aG9sbXMudHlwZXMubW9uZXkucnBjLk1hc3RlckZvbGlvU2VydmljZVJlcXVl",
            "c3RNYXN0ZXJGb2xpb1Jlc3BvbnNlEpYBChFSZW1vdmVNYXN0ZXJGb2xpbxI9",
            "LmhvbG1zLnR5cGVzLm1vbmV5LnJwYy5NYXN0ZXJGb2xpb1N2Y1JlbW92ZU1h",
            "c3RlckZvbGlvUmVxdWVzdBpCLmhvbG1zLnR5cGVzLm1vbmV5LnJwYy5NYXN0",
            "ZXJGb2xpb1NlcnZpY2VSZW1vdmVNYXN0ZXJGb2xpb1Jlc3BvbnNlQhiqAhVI",
            "T0xNUy5UeXBlcy5Nb25leS5SUENiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::HOLMS.Types.Booking.Indicators.ReservationIndicatorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::HOLMS.Types.Money.RPC.ReservationFolioSvcRequestMasterFolioResult), typeof(global::HOLMS.Types.Money.RPC.ReservationFolioSvcRemoveMasterFolioResult), }, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Money.RPC.MasterFolioServiceMasterFolioRequest), global::HOLMS.Types.Money.RPC.MasterFolioServiceMasterFolioRequest.Parser, new[]{ "ClientFolio", "MasterFolio", "MasterAccruesLodging", "MasterAccruesIncidentals" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Money.RPC.MasterFolioServiceRequestMasterFolioResponse), global::HOLMS.Types.Money.RPC.MasterFolioServiceRequestMasterFolioResponse.Parser, new[]{ "Result" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Money.RPC.MasterFolioSvcRemoveMasterFolioRequest), global::HOLMS.Types.Money.RPC.MasterFolioSvcRemoveMasterFolioRequest.Parser, new[]{ "ClientFolio" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Money.RPC.MasterFolioServiceRemoveMasterFolioResponse), global::HOLMS.Types.Money.RPC.MasterFolioServiceRemoveMasterFolioResponse.Parser, new[]{ "Result" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Enums
  public enum ReservationFolioSvcRequestMasterFolioResult {
    [pbr::OriginalName("MASTER_FOLIO_SVC_REQUEST_MASTER_FOLIO_OK")] MasterFolioSvcRequestMasterFolioOk = 0,
    [pbr::OriginalName("MASTER_FOLIO_SVC_REQUEST_MASTER_FOLIO_CLIENT_HAS_MASTER")] MasterFolioSvcRequestMasterFolioClientHasMaster = 1,
    [pbr::OriginalName("MASTER_FOLIO_SVC_REQUEST_MASTER_FOLIO_MASTER_HAS_MASTER")] MasterFolioSvcRequestMasterFolioMasterHasMaster = 2,
    [pbr::OriginalName("MASTER_FOLIO_SVC_REQUEST_CLIENT_HAS_CLIENT")] MasterFolioSvcRequestClientHasClient = 3,
    [pbr::OriginalName("MASTER_FOLIO_SVC_REQUEST_MASTER_FOLIO_DISALLOWED_MASTER")] MasterFolioSvcRequestMasterFolioDisallowedMaster = 4,
    [pbr::OriginalName("MASTER_FOLIO_SVC_REQUEST_MASTER_FOLIO_DISALLOWED_CLIENT")] MasterFolioSvcRequestMasterFolioDisallowedClient = 5,
    [pbr::OriginalName("MASTER_FOLIO_SVC_REQUEST_MASTER_FOLIO_FAILURE")] MasterFolioSvcRequestMasterFolioFailure = 6,
  }

  public enum ReservationFolioSvcRemoveMasterFolioResult {
    [pbr::OriginalName("MASTER_FOLIO_SVC_REMOVE_MASTER_FOLIO_OK")] MasterFolioSvcRemoveMasterFolioOk = 0,
    [pbr::OriginalName("MASTER_FOLIO_SVC_REMOVE_MASTER_FOLIO_NO_MASTER")] MasterFolioSvcRemoveMasterFolioNoMaster = 1,
    [pbr::OriginalName("MASTER_FOLIO_SVC_REMOVE_MASTER_FOLIO_FAILURE")] MasterFolioSvcRemoveMasterFolioFailure = 2,
  }

  #endregion

  #region Messages
  public sealed partial class MasterFolioServiceMasterFolioRequest : pb::IMessage<MasterFolioServiceMasterFolioRequest> {
    private static readonly pb::MessageParser<MasterFolioServiceMasterFolioRequest> _parser = new pb::MessageParser<MasterFolioServiceMasterFolioRequest>(() => new MasterFolioServiceMasterFolioRequest());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<MasterFolioServiceMasterFolioRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Money.RPC.MasterFolioSvcReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MasterFolioServiceMasterFolioRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MasterFolioServiceMasterFolioRequest(MasterFolioServiceMasterFolioRequest other) : this() {
      ClientFolio = other.clientFolio_ != null ? other.ClientFolio.Clone() : null;
      MasterFolio = other.masterFolio_ != null ? other.MasterFolio.Clone() : null;
      masterAccruesLodging_ = other.masterAccruesLodging_;
      masterAccruesIncidentals_ = other.masterAccruesIncidentals_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MasterFolioServiceMasterFolioRequest Clone() {
      return new MasterFolioServiceMasterFolioRequest(this);
    }

    /// <summary>Field number for the "client_folio" field.</summary>
    public const int ClientFolioFieldNumber = 1;
    private global::HOLMS.Types.Booking.Indicators.ReservationIndicator clientFolio_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Booking.Indicators.ReservationIndicator ClientFolio {
      get { return clientFolio_; }
      set {
        clientFolio_ = value;
      }
    }

    /// <summary>Field number for the "master_folio" field.</summary>
    public const int MasterFolioFieldNumber = 2;
    private global::HOLMS.Types.Booking.Indicators.ReservationIndicator masterFolio_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Booking.Indicators.ReservationIndicator MasterFolio {
      get { return masterFolio_; }
      set {
        masterFolio_ = value;
      }
    }

    /// <summary>Field number for the "master_accrues_lodging" field.</summary>
    public const int MasterAccruesLodgingFieldNumber = 3;
    private bool masterAccruesLodging_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool MasterAccruesLodging {
      get { return masterAccruesLodging_; }
      set {
        masterAccruesLodging_ = value;
      }
    }

    /// <summary>Field number for the "master_accrues_incidentals" field.</summary>
    public const int MasterAccruesIncidentalsFieldNumber = 4;
    private bool masterAccruesIncidentals_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool MasterAccruesIncidentals {
      get { return masterAccruesIncidentals_; }
      set {
        masterAccruesIncidentals_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as MasterFolioServiceMasterFolioRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(MasterFolioServiceMasterFolioRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(ClientFolio, other.ClientFolio)) return false;
      if (!object.Equals(MasterFolio, other.MasterFolio)) return false;
      if (MasterAccruesLodging != other.MasterAccruesLodging) return false;
      if (MasterAccruesIncidentals != other.MasterAccruesIncidentals) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (clientFolio_ != null) hash ^= ClientFolio.GetHashCode();
      if (masterFolio_ != null) hash ^= MasterFolio.GetHashCode();
      if (MasterAccruesLodging != false) hash ^= MasterAccruesLodging.GetHashCode();
      if (MasterAccruesIncidentals != false) hash ^= MasterAccruesIncidentals.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (clientFolio_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(ClientFolio);
      }
      if (masterFolio_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(MasterFolio);
      }
      if (MasterAccruesLodging != false) {
        output.WriteRawTag(24);
        output.WriteBool(MasterAccruesLodging);
      }
      if (MasterAccruesIncidentals != false) {
        output.WriteRawTag(32);
        output.WriteBool(MasterAccruesIncidentals);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (clientFolio_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ClientFolio);
      }
      if (masterFolio_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(MasterFolio);
      }
      if (MasterAccruesLodging != false) {
        size += 1 + 1;
      }
      if (MasterAccruesIncidentals != false) {
        size += 1 + 1;
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(MasterFolioServiceMasterFolioRequest other) {
      if (other == null) {
        return;
      }
      if (other.clientFolio_ != null) {
        if (clientFolio_ == null) {
          clientFolio_ = new global::HOLMS.Types.Booking.Indicators.ReservationIndicator();
        }
        ClientFolio.MergeFrom(other.ClientFolio);
      }
      if (other.masterFolio_ != null) {
        if (masterFolio_ == null) {
          masterFolio_ = new global::HOLMS.Types.Booking.Indicators.ReservationIndicator();
        }
        MasterFolio.MergeFrom(other.MasterFolio);
      }
      if (other.MasterAccruesLodging != false) {
        MasterAccruesLodging = other.MasterAccruesLodging;
      }
      if (other.MasterAccruesIncidentals != false) {
        MasterAccruesIncidentals = other.MasterAccruesIncidentals;
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
            if (clientFolio_ == null) {
              clientFolio_ = new global::HOLMS.Types.Booking.Indicators.ReservationIndicator();
            }
            input.ReadMessage(clientFolio_);
            break;
          }
          case 18: {
            if (masterFolio_ == null) {
              masterFolio_ = new global::HOLMS.Types.Booking.Indicators.ReservationIndicator();
            }
            input.ReadMessage(masterFolio_);
            break;
          }
          case 24: {
            MasterAccruesLodging = input.ReadBool();
            break;
          }
          case 32: {
            MasterAccruesIncidentals = input.ReadBool();
            break;
          }
        }
      }
    }

  }

  public sealed partial class MasterFolioServiceRequestMasterFolioResponse : pb::IMessage<MasterFolioServiceRequestMasterFolioResponse> {
    private static readonly pb::MessageParser<MasterFolioServiceRequestMasterFolioResponse> _parser = new pb::MessageParser<MasterFolioServiceRequestMasterFolioResponse>(() => new MasterFolioServiceRequestMasterFolioResponse());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<MasterFolioServiceRequestMasterFolioResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Money.RPC.MasterFolioSvcReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MasterFolioServiceRequestMasterFolioResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MasterFolioServiceRequestMasterFolioResponse(MasterFolioServiceRequestMasterFolioResponse other) : this() {
      result_ = other.result_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MasterFolioServiceRequestMasterFolioResponse Clone() {
      return new MasterFolioServiceRequestMasterFolioResponse(this);
    }

    /// <summary>Field number for the "result" field.</summary>
    public const int ResultFieldNumber = 1;
    private global::HOLMS.Types.Money.RPC.ReservationFolioSvcRequestMasterFolioResult result_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Money.RPC.ReservationFolioSvcRequestMasterFolioResult Result {
      get { return result_; }
      set {
        result_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as MasterFolioServiceRequestMasterFolioResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(MasterFolioServiceRequestMasterFolioResponse other) {
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
    public void MergeFrom(MasterFolioServiceRequestMasterFolioResponse other) {
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
            result_ = (global::HOLMS.Types.Money.RPC.ReservationFolioSvcRequestMasterFolioResult) input.ReadEnum();
            break;
          }
        }
      }
    }

  }

  public sealed partial class MasterFolioSvcRemoveMasterFolioRequest : pb::IMessage<MasterFolioSvcRemoveMasterFolioRequest> {
    private static readonly pb::MessageParser<MasterFolioSvcRemoveMasterFolioRequest> _parser = new pb::MessageParser<MasterFolioSvcRemoveMasterFolioRequest>(() => new MasterFolioSvcRemoveMasterFolioRequest());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<MasterFolioSvcRemoveMasterFolioRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Money.RPC.MasterFolioSvcReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MasterFolioSvcRemoveMasterFolioRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MasterFolioSvcRemoveMasterFolioRequest(MasterFolioSvcRemoveMasterFolioRequest other) : this() {
      ClientFolio = other.clientFolio_ != null ? other.ClientFolio.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MasterFolioSvcRemoveMasterFolioRequest Clone() {
      return new MasterFolioSvcRemoveMasterFolioRequest(this);
    }

    /// <summary>Field number for the "client_folio" field.</summary>
    public const int ClientFolioFieldNumber = 1;
    private global::HOLMS.Types.Booking.Indicators.ReservationIndicator clientFolio_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Booking.Indicators.ReservationIndicator ClientFolio {
      get { return clientFolio_; }
      set {
        clientFolio_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as MasterFolioSvcRemoveMasterFolioRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(MasterFolioSvcRemoveMasterFolioRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(ClientFolio, other.ClientFolio)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (clientFolio_ != null) hash ^= ClientFolio.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (clientFolio_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(ClientFolio);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (clientFolio_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ClientFolio);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(MasterFolioSvcRemoveMasterFolioRequest other) {
      if (other == null) {
        return;
      }
      if (other.clientFolio_ != null) {
        if (clientFolio_ == null) {
          clientFolio_ = new global::HOLMS.Types.Booking.Indicators.ReservationIndicator();
        }
        ClientFolio.MergeFrom(other.ClientFolio);
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
            if (clientFolio_ == null) {
              clientFolio_ = new global::HOLMS.Types.Booking.Indicators.ReservationIndicator();
            }
            input.ReadMessage(clientFolio_);
            break;
          }
        }
      }
    }

  }

  public sealed partial class MasterFolioServiceRemoveMasterFolioResponse : pb::IMessage<MasterFolioServiceRemoveMasterFolioResponse> {
    private static readonly pb::MessageParser<MasterFolioServiceRemoveMasterFolioResponse> _parser = new pb::MessageParser<MasterFolioServiceRemoveMasterFolioResponse>(() => new MasterFolioServiceRemoveMasterFolioResponse());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<MasterFolioServiceRemoveMasterFolioResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Money.RPC.MasterFolioSvcReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MasterFolioServiceRemoveMasterFolioResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MasterFolioServiceRemoveMasterFolioResponse(MasterFolioServiceRemoveMasterFolioResponse other) : this() {
      result_ = other.result_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MasterFolioServiceRemoveMasterFolioResponse Clone() {
      return new MasterFolioServiceRemoveMasterFolioResponse(this);
    }

    /// <summary>Field number for the "result" field.</summary>
    public const int ResultFieldNumber = 1;
    private global::HOLMS.Types.Money.RPC.ReservationFolioSvcRemoveMasterFolioResult result_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Money.RPC.ReservationFolioSvcRemoveMasterFolioResult Result {
      get { return result_; }
      set {
        result_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as MasterFolioServiceRemoveMasterFolioResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(MasterFolioServiceRemoveMasterFolioResponse other) {
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
    public void MergeFrom(MasterFolioServiceRemoveMasterFolioResponse other) {
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
            result_ = (global::HOLMS.Types.Money.RPC.ReservationFolioSvcRemoveMasterFolioResult) input.ReadEnum();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
