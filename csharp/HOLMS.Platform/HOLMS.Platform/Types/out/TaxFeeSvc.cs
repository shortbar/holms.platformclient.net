// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: money/rpc/tax_fee_svc.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HOLMS.Types.Money.RPC {

  /// <summary>Holder for reflection information generated from money/rpc/tax_fee_svc.proto</summary>
  public static partial class TaxFeeSvcReflection {

    #region Descriptor
    /// <summary>File descriptor for money/rpc/tax_fee_svc.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TaxFeeSvcReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Chttb25leS9ycGMvdGF4X2ZlZV9zdmMucHJvdG8SFWhvbG1zLnR5cGVzLm1v",
            "bmV5LnJwYxoqcHJpbWl0aXZlL3NlcnZlcl9hY3Rpb25fY29uZmlybWF0aW9u",
            "LnByb3RvGhtnb29nbGUvcHJvdG9idWYvZW1wdHkucHJvdG8aHm1vbmV5L2Fj",
            "Y291bnRpbmcvdGF4X2ZlZS5wcm90bxoobW9uZXkvYWNjb3VudGluZy90YXhf",
            "ZmVlX2luZGljYXRvci5wcm90byJOChRUYXhGZWVTdmNBbGxSZXNwb25zZRI2",
            "Cgh0YXhfZmVlcxgBIAMoCzIkLmhvbG1zLnR5cGVzLm1vbmV5LmFjY291bnRp",
            "bmcuVGF4RmVlMsQDCglUYXhGZWVTdmMSSgoDQWxsEhYuZ29vZ2xlLnByb3Rv",
            "YnVmLkVtcHR5GisuaG9sbXMudHlwZXMubW9uZXkucnBjLlRheEZlZVN2Y0Fs",
            "bFJlc3BvbnNlEl4KB0dldEJ5SWQSLS5ob2xtcy50eXBlcy5tb25leS5hY2Nv",
            "dW50aW5nLlRheEZlZUluZGljYXRvchokLmhvbG1zLnR5cGVzLm1vbmV5LmFj",
            "Y291bnRpbmcuVGF4RmVlElQKBkNyZWF0ZRIkLmhvbG1zLnR5cGVzLm1vbmV5",
            "LmFjY291bnRpbmcuVGF4RmVlGiQuaG9sbXMudHlwZXMubW9uZXkuYWNjb3Vu",
            "dGluZy5UYXhGZWUSVAoGVXBkYXRlEiQuaG9sbXMudHlwZXMubW9uZXkuYWNj",
            "b3VudGluZy5UYXhGZWUaJC5ob2xtcy50eXBlcy5tb25leS5hY2NvdW50aW5n",
            "LlRheEZlZRJfCgZEZWxldGUSJC5ob2xtcy50eXBlcy5tb25leS5hY2NvdW50",
            "aW5nLlRheEZlZRovLmhvbG1zLnR5cGVzLnByaW1pdGl2ZS5TZXJ2ZXJBY3Rp",
            "b25Db25maXJtYXRpb25CI1oJbW9uZXkvcnBjqgIVSE9MTVMuVHlwZXMuTW9u",
            "ZXkuUlBDYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::HOLMS.Types.Primitive.ServerActionConfirmationReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.EmptyReflection.Descriptor, global::HOLMS.Types.Money.Accounting.TaxFeeReflection.Descriptor, global::HOLMS.Types.Money.Accounting.TaxFeeIndicatorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Money.RPC.TaxFeeSvcAllResponse), global::HOLMS.Types.Money.RPC.TaxFeeSvcAllResponse.Parser, new[]{ "TaxFees" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class TaxFeeSvcAllResponse : pb::IMessage<TaxFeeSvcAllResponse> {
    private static readonly pb::MessageParser<TaxFeeSvcAllResponse> _parser = new pb::MessageParser<TaxFeeSvcAllResponse>(() => new TaxFeeSvcAllResponse());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<TaxFeeSvcAllResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Money.RPC.TaxFeeSvcReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TaxFeeSvcAllResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TaxFeeSvcAllResponse(TaxFeeSvcAllResponse other) : this() {
      taxFees_ = other.taxFees_.Clone();
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TaxFeeSvcAllResponse Clone() {
      return new TaxFeeSvcAllResponse(this);
    }

    /// <summary>Field number for the "tax_fees" field.</summary>
    public const int TaxFeesFieldNumber = 1;
    private static readonly pb::FieldCodec<global::HOLMS.Types.Money.Accounting.TaxFee> _repeated_taxFees_codec
        = pb::FieldCodec.ForMessage(10, global::HOLMS.Types.Money.Accounting.TaxFee.Parser);
    private readonly pbc::RepeatedField<global::HOLMS.Types.Money.Accounting.TaxFee> taxFees_ = new pbc::RepeatedField<global::HOLMS.Types.Money.Accounting.TaxFee>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::HOLMS.Types.Money.Accounting.TaxFee> TaxFees {
      get { return taxFees_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as TaxFeeSvcAllResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(TaxFeeSvcAllResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!taxFees_.Equals(other.taxFees_)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= taxFees_.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      taxFees_.WriteTo(output, _repeated_taxFees_codec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += taxFees_.CalculateSize(_repeated_taxFees_codec);
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(TaxFeeSvcAllResponse other) {
      if (other == null) {
        return;
      }
      taxFees_.Add(other.taxFees_);
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
            taxFees_.AddEntriesFrom(input, _repeated_taxFees_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
