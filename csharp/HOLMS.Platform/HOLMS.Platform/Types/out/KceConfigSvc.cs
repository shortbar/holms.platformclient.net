// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: tenancy_config/rpc/kce_config_svc.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HOLMS.Types.TenancyConfig.RPC {

  /// <summary>Holder for reflection information generated from tenancy_config/rpc/kce_config_svc.proto</summary>
  public static partial class KceConfigSvcReflection {

    #region Descriptor
    /// <summary>File descriptor for tenancy_config/rpc/kce_config_svc.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static KceConfigSvcReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cid0ZW5hbmN5X2NvbmZpZy9ycGMva2NlX2NvbmZpZ19zdmMucHJvdG8SHmhv",
            "bG1zLnR5cGVzLnRlbmFuY3lfY29uZmlnLnJwYxogdGVuYW5jeV9jb25maWcv",
            "a2FiYV9jb25maWcucHJvdG8aIHRlbmFuY3lfY29uZmlnL21pd2FfY29uZmln",
            "LnByb3RvGi10ZW5hbmN5X2NvbmZpZy9hY3RpdmVfa2NlX2NvbmZpZ3VyYXRp",
            "b24ucHJvdG8aG2dvb2dsZS9wcm90b2J1Zi9lbXB0eS5wcm90byLtAQoUR2V0",
            "S0NFQ29uZmlnUmVzcG9uc2USQgoSa2FiYV9jb25maWd1cmF0aW9uGAEgASgL",
            "MiYuaG9sbXMudHlwZXMudGVuYW5jeV9jb25maWcuS2FiYUNvbmZpZxJCChJt",
            "aXdhX2NvbmZpZ3VyYXRpb24YAiABKAsyJi5ob2xtcy50eXBlcy50ZW5hbmN5",
            "X2NvbmZpZy5NaXdhQ29uZmlnEk0KEWFjdGl2ZV9rY2VfY29uZmlnGAMgASgO",
            "MjIuaG9sbXMudHlwZXMudGVuYW5jeV9jb25maWcuQWN0aXZlS0NFQ29uZmln",
            "dXJhdGlvbiJiChVTZXRLYWJhQ29uZmlnUmVzcG9uc2USSQoGcmVzdWx0GAEg",
            "ASgOMjkuaG9sbXMudHlwZXMudGVuYW5jeV9jb25maWcucnBjLktDRVN2Y1Nl",
            "dEthYmFDb25maWdSZXN1bHQiYgobS0NFU3ZjU2V0TWl3YUNvbmZpZ1Jlc3Bv",
            "bnNlEkMKBnJlc3VsdBgBIAEoDjIzLmhvbG1zLnR5cGVzLnRlbmFuY3lfY29u",
            "ZmlnLnJwYy5TZXRNaXdhQ29uZmlnUmVzdWx0InAKH0tDRVN2Y1NldEFjdGl2",
            "ZUtDRUNvbmZpZ1JlcXVlc3QSTQoRYWN0aXZlX2tjZV9jb25maWcYASABKA4y",
            "Mi5ob2xtcy50eXBlcy50ZW5hbmN5X2NvbmZpZy5BY3RpdmVLQ0VDb25maWd1",
            "cmF0aW9uKs0BChlLQ0VTdmNTZXRLYWJhQ29uZmlnUmVzdWx0EiUKIVNFVF9L",
            "Q0VfQ09ORklHX0lOVkFMSURfSVBfQUREUkVTUxAAEikKJVNFVF9LQ0VfQ09O",
            "RklHX0lOVkFMSURfRU5DT0RFUl9OVU1CRVIQARIeChpTRVRfS0NFX0NPTkZJ",
            "R19JTlZBTElEX1BXRBACEiIKHlNFVF9LQ0VfQ09ORklHX1VOS05PV05fRkFJ",
            "TFVSRRADEhoKFlNFVF9LQ0VfQ09ORklHX1NVQ0NFU1MQBCqsAQoTU2V0TWl3",
            "YUNvbmZpZ1Jlc3VsdBImCiJTRVRfTUlXQV9DT05GSUdfSU5WQUxJRF9JUF9B",
            "RERSRVNTEAASKwonU0VUX01JV0FfQ09ORklHX0lOVkFMSURfVEVSTUlOQUxf",
            "TlVNQkVSEAESIwofU0VUX01JV0FfQ09ORklHX1VOS05PV05fRkFJTFVSRRAC",
            "EhsKF1NFVF9NSVdBX0NPTkZJR19TVUNDRVNTEAMyvwMKDEtDRUNvbmZpZ1N2",
            "YxJTCgNHZXQSFi5nb29nbGUucHJvdG9idWYuRW1wdHkaNC5ob2xtcy50eXBl",
            "cy50ZW5hbmN5X2NvbmZpZy5ycGMuR2V0S0NFQ29uZmlnUmVzcG9uc2USbgoN",
            "U2V0S2FiYUNvbmZpZxImLmhvbG1zLnR5cGVzLnRlbmFuY3lfY29uZmlnLkth",
            "YmFDb25maWcaNS5ob2xtcy50eXBlcy50ZW5hbmN5X2NvbmZpZy5ycGMuU2V0",
            "S2FiYUNvbmZpZ1Jlc3BvbnNlEnQKDVNldE1pd2FDb25maWcSJi5ob2xtcy50",
            "eXBlcy50ZW5hbmN5X2NvbmZpZy5NaXdhQ29uZmlnGjsuaG9sbXMudHlwZXMu",
            "dGVuYW5jeV9jb25maWcucnBjLktDRVN2Y1NldE1pd2FDb25maWdSZXNwb25z",
            "ZRJ0ChlTZXRBY3RpdmVLQ0VDb25maWd1cmF0aW9uEj8uaG9sbXMudHlwZXMu",
            "dGVuYW5jeV9jb25maWcucnBjLktDRVN2Y1NldEFjdGl2ZUtDRUNvbmZpZ1Jl",
            "cXVlc3QaFi5nb29nbGUucHJvdG9idWYuRW1wdHlCM1oRdGVuYW5jeWNvbmZp",
            "Zy9ycGOqAh1IT0xNUy5UeXBlcy5UZW5hbmN5Q29uZmlnLlJQQ2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::HOLMS.Types.TenancyConfig.KabaConfigReflection.Descriptor, global::HOLMS.Types.TenancyConfig.MiwaConfigReflection.Descriptor, global::HOLMS.Types.TenancyConfig.ActiveKceConfigurationReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.EmptyReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::HOLMS.Types.TenancyConfig.RPC.KCESvcSetKabaConfigResult), typeof(global::HOLMS.Types.TenancyConfig.RPC.SetMiwaConfigResult), }, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.TenancyConfig.RPC.GetKCEConfigResponse), global::HOLMS.Types.TenancyConfig.RPC.GetKCEConfigResponse.Parser, new[]{ "KabaConfiguration", "MiwaConfiguration", "ActiveKceConfig" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.TenancyConfig.RPC.SetKabaConfigResponse), global::HOLMS.Types.TenancyConfig.RPC.SetKabaConfigResponse.Parser, new[]{ "Result" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.TenancyConfig.RPC.KCESvcSetMiwaConfigResponse), global::HOLMS.Types.TenancyConfig.RPC.KCESvcSetMiwaConfigResponse.Parser, new[]{ "Result" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.TenancyConfig.RPC.KCESvcSetActiveKCEConfigRequest), global::HOLMS.Types.TenancyConfig.RPC.KCESvcSetActiveKCEConfigRequest.Parser, new[]{ "ActiveKceConfig" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Enums
  public enum KCESvcSetKabaConfigResult {
    [pbr::OriginalName("SET_KCE_CONFIG_INVALID_IP_ADDRESS")] SetKceConfigInvalidIpAddress = 0,
    [pbr::OriginalName("SET_KCE_CONFIG_INVALID_ENCODER_NUMBER")] SetKceConfigInvalidEncoderNumber = 1,
    [pbr::OriginalName("SET_KCE_CONFIG_INVALID_PWD")] SetKceConfigInvalidPwd = 2,
    [pbr::OriginalName("SET_KCE_CONFIG_UNKNOWN_FAILURE")] SetKceConfigUnknownFailure = 3,
    [pbr::OriginalName("SET_KCE_CONFIG_SUCCESS")] SetKceConfigSuccess = 4,
  }

  public enum SetMiwaConfigResult {
    [pbr::OriginalName("SET_MIWA_CONFIG_INVALID_IP_ADDRESS")] SetMiwaConfigInvalidIpAddress = 0,
    [pbr::OriginalName("SET_MIWA_CONFIG_INVALID_TERMINAL_NUMBER")] SetMiwaConfigInvalidTerminalNumber = 1,
    [pbr::OriginalName("SET_MIWA_CONFIG_UNKNOWN_FAILURE")] SetMiwaConfigUnknownFailure = 2,
    [pbr::OriginalName("SET_MIWA_CONFIG_SUCCESS")] SetMiwaConfigSuccess = 3,
  }

  #endregion

  #region Messages
  public sealed partial class GetKCEConfigResponse : pb::IMessage<GetKCEConfigResponse> {
    private static readonly pb::MessageParser<GetKCEConfigResponse> _parser = new pb::MessageParser<GetKCEConfigResponse>(() => new GetKCEConfigResponse());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetKCEConfigResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.TenancyConfig.RPC.KceConfigSvcReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetKCEConfigResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetKCEConfigResponse(GetKCEConfigResponse other) : this() {
      KabaConfiguration = other.kabaConfiguration_ != null ? other.KabaConfiguration.Clone() : null;
      MiwaConfiguration = other.miwaConfiguration_ != null ? other.MiwaConfiguration.Clone() : null;
      activeKceConfig_ = other.activeKceConfig_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetKCEConfigResponse Clone() {
      return new GetKCEConfigResponse(this);
    }

    /// <summary>Field number for the "kaba_configuration" field.</summary>
    public const int KabaConfigurationFieldNumber = 1;
    private global::HOLMS.Types.TenancyConfig.KabaConfig kabaConfiguration_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.TenancyConfig.KabaConfig KabaConfiguration {
      get { return kabaConfiguration_; }
      set {
        kabaConfiguration_ = value;
      }
    }

    /// <summary>Field number for the "miwa_configuration" field.</summary>
    public const int MiwaConfigurationFieldNumber = 2;
    private global::HOLMS.Types.TenancyConfig.MiwaConfig miwaConfiguration_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.TenancyConfig.MiwaConfig MiwaConfiguration {
      get { return miwaConfiguration_; }
      set {
        miwaConfiguration_ = value;
      }
    }

    /// <summary>Field number for the "active_kce_config" field.</summary>
    public const int ActiveKceConfigFieldNumber = 3;
    private global::HOLMS.Types.TenancyConfig.ActiveKCEConfiguration activeKceConfig_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.TenancyConfig.ActiveKCEConfiguration ActiveKceConfig {
      get { return activeKceConfig_; }
      set {
        activeKceConfig_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GetKCEConfigResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetKCEConfigResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(KabaConfiguration, other.KabaConfiguration)) return false;
      if (!object.Equals(MiwaConfiguration, other.MiwaConfiguration)) return false;
      if (ActiveKceConfig != other.ActiveKceConfig) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (kabaConfiguration_ != null) hash ^= KabaConfiguration.GetHashCode();
      if (miwaConfiguration_ != null) hash ^= MiwaConfiguration.GetHashCode();
      if (ActiveKceConfig != 0) hash ^= ActiveKceConfig.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (kabaConfiguration_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(KabaConfiguration);
      }
      if (miwaConfiguration_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(MiwaConfiguration);
      }
      if (ActiveKceConfig != 0) {
        output.WriteRawTag(24);
        output.WriteEnum((int) ActiveKceConfig);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (kabaConfiguration_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(KabaConfiguration);
      }
      if (miwaConfiguration_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(MiwaConfiguration);
      }
      if (ActiveKceConfig != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ActiveKceConfig);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GetKCEConfigResponse other) {
      if (other == null) {
        return;
      }
      if (other.kabaConfiguration_ != null) {
        if (kabaConfiguration_ == null) {
          kabaConfiguration_ = new global::HOLMS.Types.TenancyConfig.KabaConfig();
        }
        KabaConfiguration.MergeFrom(other.KabaConfiguration);
      }
      if (other.miwaConfiguration_ != null) {
        if (miwaConfiguration_ == null) {
          miwaConfiguration_ = new global::HOLMS.Types.TenancyConfig.MiwaConfig();
        }
        MiwaConfiguration.MergeFrom(other.MiwaConfiguration);
      }
      if (other.ActiveKceConfig != 0) {
        ActiveKceConfig = other.ActiveKceConfig;
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
            if (kabaConfiguration_ == null) {
              kabaConfiguration_ = new global::HOLMS.Types.TenancyConfig.KabaConfig();
            }
            input.ReadMessage(kabaConfiguration_);
            break;
          }
          case 18: {
            if (miwaConfiguration_ == null) {
              miwaConfiguration_ = new global::HOLMS.Types.TenancyConfig.MiwaConfig();
            }
            input.ReadMessage(miwaConfiguration_);
            break;
          }
          case 24: {
            activeKceConfig_ = (global::HOLMS.Types.TenancyConfig.ActiveKCEConfiguration) input.ReadEnum();
            break;
          }
        }
      }
    }

  }

  public sealed partial class SetKabaConfigResponse : pb::IMessage<SetKabaConfigResponse> {
    private static readonly pb::MessageParser<SetKabaConfigResponse> _parser = new pb::MessageParser<SetKabaConfigResponse>(() => new SetKabaConfigResponse());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<SetKabaConfigResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.TenancyConfig.RPC.KceConfigSvcReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SetKabaConfigResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SetKabaConfigResponse(SetKabaConfigResponse other) : this() {
      result_ = other.result_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SetKabaConfigResponse Clone() {
      return new SetKabaConfigResponse(this);
    }

    /// <summary>Field number for the "result" field.</summary>
    public const int ResultFieldNumber = 1;
    private global::HOLMS.Types.TenancyConfig.RPC.KCESvcSetKabaConfigResult result_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.TenancyConfig.RPC.KCESvcSetKabaConfigResult Result {
      get { return result_; }
      set {
        result_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as SetKabaConfigResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(SetKabaConfigResponse other) {
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
    public void MergeFrom(SetKabaConfigResponse other) {
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
            result_ = (global::HOLMS.Types.TenancyConfig.RPC.KCESvcSetKabaConfigResult) input.ReadEnum();
            break;
          }
        }
      }
    }

  }

  public sealed partial class KCESvcSetMiwaConfigResponse : pb::IMessage<KCESvcSetMiwaConfigResponse> {
    private static readonly pb::MessageParser<KCESvcSetMiwaConfigResponse> _parser = new pb::MessageParser<KCESvcSetMiwaConfigResponse>(() => new KCESvcSetMiwaConfigResponse());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<KCESvcSetMiwaConfigResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.TenancyConfig.RPC.KceConfigSvcReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public KCESvcSetMiwaConfigResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public KCESvcSetMiwaConfigResponse(KCESvcSetMiwaConfigResponse other) : this() {
      result_ = other.result_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public KCESvcSetMiwaConfigResponse Clone() {
      return new KCESvcSetMiwaConfigResponse(this);
    }

    /// <summary>Field number for the "result" field.</summary>
    public const int ResultFieldNumber = 1;
    private global::HOLMS.Types.TenancyConfig.RPC.SetMiwaConfigResult result_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.TenancyConfig.RPC.SetMiwaConfigResult Result {
      get { return result_; }
      set {
        result_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as KCESvcSetMiwaConfigResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(KCESvcSetMiwaConfigResponse other) {
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
    public void MergeFrom(KCESvcSetMiwaConfigResponse other) {
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
            result_ = (global::HOLMS.Types.TenancyConfig.RPC.SetMiwaConfigResult) input.ReadEnum();
            break;
          }
        }
      }
    }

  }

  public sealed partial class KCESvcSetActiveKCEConfigRequest : pb::IMessage<KCESvcSetActiveKCEConfigRequest> {
    private static readonly pb::MessageParser<KCESvcSetActiveKCEConfigRequest> _parser = new pb::MessageParser<KCESvcSetActiveKCEConfigRequest>(() => new KCESvcSetActiveKCEConfigRequest());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<KCESvcSetActiveKCEConfigRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.TenancyConfig.RPC.KceConfigSvcReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public KCESvcSetActiveKCEConfigRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public KCESvcSetActiveKCEConfigRequest(KCESvcSetActiveKCEConfigRequest other) : this() {
      activeKceConfig_ = other.activeKceConfig_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public KCESvcSetActiveKCEConfigRequest Clone() {
      return new KCESvcSetActiveKCEConfigRequest(this);
    }

    /// <summary>Field number for the "active_kce_config" field.</summary>
    public const int ActiveKceConfigFieldNumber = 1;
    private global::HOLMS.Types.TenancyConfig.ActiveKCEConfiguration activeKceConfig_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.TenancyConfig.ActiveKCEConfiguration ActiveKceConfig {
      get { return activeKceConfig_; }
      set {
        activeKceConfig_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as KCESvcSetActiveKCEConfigRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(KCESvcSetActiveKCEConfigRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ActiveKceConfig != other.ActiveKceConfig) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ActiveKceConfig != 0) hash ^= ActiveKceConfig.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (ActiveKceConfig != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) ActiveKceConfig);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ActiveKceConfig != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ActiveKceConfig);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(KCESvcSetActiveKCEConfigRequest other) {
      if (other == null) {
        return;
      }
      if (other.ActiveKceConfig != 0) {
        ActiveKceConfig = other.ActiveKceConfig;
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
            activeKceConfig_ = (global::HOLMS.Types.TenancyConfig.ActiveKCEConfiguration) input.ReadEnum();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
