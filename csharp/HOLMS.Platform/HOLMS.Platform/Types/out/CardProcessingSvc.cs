// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: money/rpc/card_processing_svc.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HOLMS.Types.Money.RPC {

  /// <summary>Holder for reflection information generated from money/rpc/card_processing_svc.proto</summary>
  public static partial class CardProcessingSvcReflection {

    #region Descriptor
    /// <summary>File descriptor for money/rpc/card_processing_svc.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CardProcessingSvcReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiNtb25leS9ycGMvY2FyZF9wcm9jZXNzaW5nX3N2Yy5wcm90bxIVaG9sbXMu",
            "dHlwZXMubW9uZXkucnBjGiBjcm0vZ3Vlc3RzL2d1ZXN0X2luZGljYXRvci5w",
            "cm90bxopbW9uZXkvY2FyZHMvY2FyZF9tZXJjaGFudF9pbmRpY2F0b3IucHJv",
            "dG8aMW1vbmV5L2NhcmRzL2N1c3RvbWVyX3BheW1lbnRfY2FyZF9pbmRpY2F0",
            "b3IucHJvdG8aKm1vbmV5L2NhcmRzL25vdF9wcmVzZW50X3BheW1lbnRfY2Fy",
            "ZC5wcm90bxo0bW9uZXkvY2FyZHMvdHJhbnNhY3Rpb25zL2Nsb3NlZF9tZXJj",
            "aGFudF9iYXRjaC5wcm90bxo8bW9uZXkvY2FyZHMvdHJhbnNhY3Rpb25zL2dl",
            "dF9vcGVuX2JhdGNoX3N0YXRlX3Jlc3BvbnNlLnByb3RvGjptb25leS9jYXJk",
            "cy90cmFuc2FjdGlvbnMvcGF5bWVudF9jYXJkX3NhbGVfaW5kaWNhdG9yLnBy",
            "b3RvGjxtb25leS9jYXJkcy90cmFuc2FjdGlvbnMvcGF5bWVudF9jYXJkX3Jl",
            "ZnVuZF9pbmRpY2F0b3IucHJvdG8aO21vbmV5L2NhcmRzL3RyYW5zYWN0aW9u",
            "cy9wcm9jZXNzb3JfdHJhbnNhY3Rpb25fcmVzdWx0LnByb3RvGjJ0ZW5hbmN5",
            "X2NvbmZpZy9pbmRpY2F0b3JzL3Byb3BlcnR5X2luZGljYXRvci5wcm90bxob",
            "cHJpbWl0aXZlL3BiX2ludGVydmFsLnByb3RvIvoBCjdDYXJkUHJvY2Vzc2lu",
            "Z1N2Y1ZlcmlmeUFuZFRva2VuaXplTm90UHJlc2VudENhcmRSZXF1ZXN0EjUK",
            "BWd1ZXN0GAEgASgLMiYuaG9sbXMudHlwZXMuY3JtLmd1ZXN0cy5HdWVzdElu",
            "ZGljYXRvchJKCghwcm9wZXJ0eRgCIAEoCzI4LmhvbG1zLnR5cGVzLnRlbmFu",
            "Y3lfY29uZmlnLmluZGljYXRvcnMuUHJvcGVydHlJbmRpY2F0b3ISPAoEY2Fy",
            "ZBgDIAEoCzIuLmhvbG1zLnR5cGVzLm1vbmV5LmNhcmRzLk5vdFByZXNlbnRQ",
            "YXltZW50Q2FyZCLRAQo4Q2FyZFByb2Nlc3NpbmdTdmNWZXJpZnlBbmRUb2tl",
            "bml6ZU5vdFByZXNlbnRDYXJkUmVzcG9uc2USUAoGcmVzdWx0GAEgASgOMkAu",
            "aG9sbXMudHlwZXMubW9uZXkuY2FyZHMudHJhbnNhY3Rpb25zLlByb2Nlc3Nv",
            "clRyYW5zYWN0aW9uUmVzdWx0EkMKBGNhcmQYAiABKAsyNS5ob2xtcy50eXBl",
            "cy5tb25leS5jYXJkcy5DdXN0b21lclBheW1lbnRDYXJkSW5kaWNhdG9yImcK",
            "GU1lcmNoYW50QmF0Y2hFbnVtUmVzcG9uc2USSgoHYmF0Y2hlcxgBIAMoCzI5",
            "LmhvbG1zLnR5cGVzLm1vbmV5LmNhcmRzLnRyYW5zYWN0aW9ucy5DbG9zZWRN",
            "ZXJjaGFudEJhdGNoIqwBCi9DYXJkUHJvY2Vzc2luZ1N2Y1NlYXJjaEhpc3Rv",
            "cmljYWxCYXRjaGVzUmVxdWVzdBJACghtZXJjaGFudBgBIAEoCzIuLmhvbG1z",
            "LnR5cGVzLm1vbmV5LmNhcmRzLkNhcmRNZXJjaGFudEluZGljYXRvchI3Cgxz",
            "ZWFyY2hfcmFuZ2UYAiABKAsyIS5ob2xtcy50eXBlcy5wcmltaXRpdmUuUGJJ",
            "bnRlcnZhbCJ5CihDYXJkUHJvY2Vzc2luZ1N2Y1ZvaWRUcmFuc2FjdGlvblJl",
            "c3BvbnNlEk0KBnJlc3VsdBgBIAEoDjI9LmhvbG1zLnR5cGVzLm1vbmV5LnJw",
            "Yy5DYXJkUHJvY2Vzc2luZ1N2Y1ZvaWRUcmFuc2FjdGlvblJlc3VsdCr/AQom",
            "Q2FyZFByb2Nlc3NpbmdTdmNWb2lkVHJhbnNhY3Rpb25SZXN1bHQSMAosQ0FS",
            "RF9QUk9DRVNTSU5HX1NWQ19WT0lEX1RSQU5TQUNUSU9OX1NVQ0NFU1MQABIy",
            "Ci5DQVJEX1BST0NFU1NJTkdfU1ZDX1ZPSURfVFJBTlNBQ1RJT05fTk9UX0ZP",
            "VU5EEAESNQoxQ0FSRF9QUk9DRVNTSU5HX1NWQ19WT0lEX1RSQU5TQUNUSU9O",
            "X05PVF9WT0lEQUJMRRACEjgKNENBUkRfUFJPQ0VTU0lOR19TVkNfVk9JRF9U",
            "UkFOU0FDVElPTl9VTktOT1dOX0ZBSUxVUkUQAzKbBwoRQ2FyZFByb2Nlc3Np",
            "bmdTdmMSwgEKH1ZlcmlmeUFuZFRva2VuaXplTm90UHJlc2VudENhcmQSTi5o",
            "b2xtcy50eXBlcy5tb25leS5ycGMuQ2FyZFByb2Nlc3NpbmdTdmNWZXJpZnlB",
            "bmRUb2tlbml6ZU5vdFByZXNlbnRDYXJkUmVxdWVzdBpPLmhvbG1zLnR5cGVz",
            "Lm1vbmV5LnJwYy5DYXJkUHJvY2Vzc2luZ1N2Y1ZlcmlmeUFuZFRva2VuaXpl",
            "Tm90UHJlc2VudENhcmRSZXNwb25zZRKHAQoUR2V0Q3VycmVudEJhdGNoU3Rh",
            "dGUSLi5ob2xtcy50eXBlcy5tb25leS5jYXJkcy5DYXJkTWVyY2hhbnRJbmRp",
            "Y2F0b3IaPy5ob2xtcy50eXBlcy5tb25leS5jYXJkcy50cmFuc2FjdGlvbnMu",
            "R2V0T3BlbkJhdGNoU3RhdGVSZXNwb25zZRKTAQoXU2VhcmNoSGlzdG9yaWNh",
            "bEJhdGNoZXMSRi5ob2xtcy50eXBlcy5tb25leS5ycGMuQ2FyZFByb2Nlc3Np",
            "bmdTdmNTZWFyY2hIaXN0b3JpY2FsQmF0Y2hlc1JlcXVlc3QaMC5ob2xtcy50",
            "eXBlcy5tb25leS5ycGMuTWVyY2hhbnRCYXRjaEVudW1SZXNwb25zZRKAAQoT",
            "Q2xvc2VQcm9jZXNzb3JCYXRjaBIuLmhvbG1zLnR5cGVzLm1vbmV5LmNhcmRz",
            "LkNhcmRNZXJjaGFudEluZGljYXRvcho5LmhvbG1zLnR5cGVzLm1vbmV5LmNh",
            "cmRzLnRyYW5zYWN0aW9ucy5DbG9zZWRNZXJjaGFudEJhdGNoEosBCghWb2lk",
            "U2FsZRI+LmhvbG1zLnR5cGVzLm1vbmV5LmNhcmRzLnRyYW5zYWN0aW9ucy5Q",
            "YXltZW50Q2FyZFNhbGVJbmRpY2F0b3IaPy5ob2xtcy50eXBlcy5tb25leS5y",
            "cGMuQ2FyZFByb2Nlc3NpbmdTdmNWb2lkVHJhbnNhY3Rpb25SZXNwb25zZRKP",
            "AQoKVm9pZFJlZnVuZBJALmhvbG1zLnR5cGVzLm1vbmV5LmNhcmRzLnRyYW5z",
            "YWN0aW9ucy5QYXltZW50Q2FyZFJlZnVuZEluZGljYXRvcho/LmhvbG1zLnR5",
            "cGVzLm1vbmV5LnJwYy5DYXJkUHJvY2Vzc2luZ1N2Y1ZvaWRUcmFuc2FjdGlv",
            "blJlc3BvbnNlQhiqAhVIT0xNUy5UeXBlcy5Nb25leS5SUENiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::HOLMS.Types.CRM.Guests.GuestIndicatorReflection.Descriptor, global::HOLMS.Types.Money.Cards.CardMerchantIndicatorReflection.Descriptor, global::HOLMS.Types.Money.Cards.CustomerPaymentCardIndicatorReflection.Descriptor, global::HOLMS.Types.Money.Cards.NotPresentPaymentCardReflection.Descriptor, global::HOLMS.Types.Money.Cards.Transactions.ClosedMerchantBatchReflection.Descriptor, global::HOLMS.Types.Money.Cards.Transactions.GetOpenBatchStateResponseReflection.Descriptor, global::HOLMS.Types.Money.Cards.Transactions.PaymentCardSaleIndicatorReflection.Descriptor, global::HOLMS.Types.Money.Cards.Transactions.PaymentCardRefundIndicatorReflection.Descriptor, global::HOLMS.Types.Money.Cards.Transactions.ProcessorTransactionResultReflection.Descriptor, global::HOLMS.Types.TenancyConfig.Indicators.PropertyIndicatorReflection.Descriptor, global::HOLMS.Types.Primitive.PbIntervalReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::HOLMS.Types.Money.RPC.CardProcessingSvcVoidTransactionResult), }, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Money.RPC.CardProcessingSvcVerifyAndTokenizeNotPresentCardRequest), global::HOLMS.Types.Money.RPC.CardProcessingSvcVerifyAndTokenizeNotPresentCardRequest.Parser, new[]{ "Guest", "Property", "Card" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Money.RPC.CardProcessingSvcVerifyAndTokenizeNotPresentCardResponse), global::HOLMS.Types.Money.RPC.CardProcessingSvcVerifyAndTokenizeNotPresentCardResponse.Parser, new[]{ "Result", "Card" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Money.RPC.MerchantBatchEnumResponse), global::HOLMS.Types.Money.RPC.MerchantBatchEnumResponse.Parser, new[]{ "Batches" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Money.RPC.CardProcessingSvcSearchHistoricalBatchesRequest), global::HOLMS.Types.Money.RPC.CardProcessingSvcSearchHistoricalBatchesRequest.Parser, new[]{ "Merchant", "SearchRange" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Money.RPC.CardProcessingSvcVoidTransactionResponse), global::HOLMS.Types.Money.RPC.CardProcessingSvcVoidTransactionResponse.Parser, new[]{ "Result" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Enums
  public enum CardProcessingSvcVoidTransactionResult {
    [pbr::OriginalName("CARD_PROCESSING_SVC_VOID_TRANSACTION_SUCCESS")] CardProcessingSvcVoidTransactionSuccess = 0,
    [pbr::OriginalName("CARD_PROCESSING_SVC_VOID_TRANSACTION_NOT_FOUND")] CardProcessingSvcVoidTransactionNotFound = 1,
    [pbr::OriginalName("CARD_PROCESSING_SVC_VOID_TRANSACTION_NOT_VOIDABLE")] CardProcessingSvcVoidTransactionNotVoidable = 2,
    [pbr::OriginalName("CARD_PROCESSING_SVC_VOID_TRANSACTION_UNKNOWN_FAILURE")] CardProcessingSvcVoidTransactionUnknownFailure = 3,
  }

  #endregion

  #region Messages
  public sealed partial class CardProcessingSvcVerifyAndTokenizeNotPresentCardRequest : pb::IMessage<CardProcessingSvcVerifyAndTokenizeNotPresentCardRequest> {
    private static readonly pb::MessageParser<CardProcessingSvcVerifyAndTokenizeNotPresentCardRequest> _parser = new pb::MessageParser<CardProcessingSvcVerifyAndTokenizeNotPresentCardRequest>(() => new CardProcessingSvcVerifyAndTokenizeNotPresentCardRequest());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CardProcessingSvcVerifyAndTokenizeNotPresentCardRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Money.RPC.CardProcessingSvcReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CardProcessingSvcVerifyAndTokenizeNotPresentCardRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CardProcessingSvcVerifyAndTokenizeNotPresentCardRequest(CardProcessingSvcVerifyAndTokenizeNotPresentCardRequest other) : this() {
      Guest = other.guest_ != null ? other.Guest.Clone() : null;
      Property = other.property_ != null ? other.Property.Clone() : null;
      Card = other.card_ != null ? other.Card.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CardProcessingSvcVerifyAndTokenizeNotPresentCardRequest Clone() {
      return new CardProcessingSvcVerifyAndTokenizeNotPresentCardRequest(this);
    }

    /// <summary>Field number for the "guest" field.</summary>
    public const int GuestFieldNumber = 1;
    private global::HOLMS.Types.CRM.Guests.GuestIndicator guest_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.CRM.Guests.GuestIndicator Guest {
      get { return guest_; }
      set {
        guest_ = value;
      }
    }

    /// <summary>Field number for the "property" field.</summary>
    public const int PropertyFieldNumber = 2;
    private global::HOLMS.Types.TenancyConfig.Indicators.PropertyIndicator property_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.TenancyConfig.Indicators.PropertyIndicator Property {
      get { return property_; }
      set {
        property_ = value;
      }
    }

    /// <summary>Field number for the "card" field.</summary>
    public const int CardFieldNumber = 3;
    private global::HOLMS.Types.Money.Cards.NotPresentPaymentCard card_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Money.Cards.NotPresentPaymentCard Card {
      get { return card_; }
      set {
        card_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CardProcessingSvcVerifyAndTokenizeNotPresentCardRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CardProcessingSvcVerifyAndTokenizeNotPresentCardRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Guest, other.Guest)) return false;
      if (!object.Equals(Property, other.Property)) return false;
      if (!object.Equals(Card, other.Card)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (guest_ != null) hash ^= Guest.GetHashCode();
      if (property_ != null) hash ^= Property.GetHashCode();
      if (card_ != null) hash ^= Card.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (guest_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Guest);
      }
      if (property_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Property);
      }
      if (card_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Card);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (guest_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Guest);
      }
      if (property_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Property);
      }
      if (card_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Card);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CardProcessingSvcVerifyAndTokenizeNotPresentCardRequest other) {
      if (other == null) {
        return;
      }
      if (other.guest_ != null) {
        if (guest_ == null) {
          guest_ = new global::HOLMS.Types.CRM.Guests.GuestIndicator();
        }
        Guest.MergeFrom(other.Guest);
      }
      if (other.property_ != null) {
        if (property_ == null) {
          property_ = new global::HOLMS.Types.TenancyConfig.Indicators.PropertyIndicator();
        }
        Property.MergeFrom(other.Property);
      }
      if (other.card_ != null) {
        if (card_ == null) {
          card_ = new global::HOLMS.Types.Money.Cards.NotPresentPaymentCard();
        }
        Card.MergeFrom(other.Card);
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
            if (guest_ == null) {
              guest_ = new global::HOLMS.Types.CRM.Guests.GuestIndicator();
            }
            input.ReadMessage(guest_);
            break;
          }
          case 18: {
            if (property_ == null) {
              property_ = new global::HOLMS.Types.TenancyConfig.Indicators.PropertyIndicator();
            }
            input.ReadMessage(property_);
            break;
          }
          case 26: {
            if (card_ == null) {
              card_ = new global::HOLMS.Types.Money.Cards.NotPresentPaymentCard();
            }
            input.ReadMessage(card_);
            break;
          }
        }
      }
    }

  }

  public sealed partial class CardProcessingSvcVerifyAndTokenizeNotPresentCardResponse : pb::IMessage<CardProcessingSvcVerifyAndTokenizeNotPresentCardResponse> {
    private static readonly pb::MessageParser<CardProcessingSvcVerifyAndTokenizeNotPresentCardResponse> _parser = new pb::MessageParser<CardProcessingSvcVerifyAndTokenizeNotPresentCardResponse>(() => new CardProcessingSvcVerifyAndTokenizeNotPresentCardResponse());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CardProcessingSvcVerifyAndTokenizeNotPresentCardResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Money.RPC.CardProcessingSvcReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CardProcessingSvcVerifyAndTokenizeNotPresentCardResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CardProcessingSvcVerifyAndTokenizeNotPresentCardResponse(CardProcessingSvcVerifyAndTokenizeNotPresentCardResponse other) : this() {
      result_ = other.result_;
      Card = other.card_ != null ? other.Card.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CardProcessingSvcVerifyAndTokenizeNotPresentCardResponse Clone() {
      return new CardProcessingSvcVerifyAndTokenizeNotPresentCardResponse(this);
    }

    /// <summary>Field number for the "result" field.</summary>
    public const int ResultFieldNumber = 1;
    private global::HOLMS.Types.Money.Cards.Transactions.ProcessorTransactionResult result_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Money.Cards.Transactions.ProcessorTransactionResult Result {
      get { return result_; }
      set {
        result_ = value;
      }
    }

    /// <summary>Field number for the "card" field.</summary>
    public const int CardFieldNumber = 2;
    private global::HOLMS.Types.Money.Cards.CustomerPaymentCardIndicator card_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Money.Cards.CustomerPaymentCardIndicator Card {
      get { return card_; }
      set {
        card_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CardProcessingSvcVerifyAndTokenizeNotPresentCardResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CardProcessingSvcVerifyAndTokenizeNotPresentCardResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Result != other.Result) return false;
      if (!object.Equals(Card, other.Card)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Result != 0) hash ^= Result.GetHashCode();
      if (card_ != null) hash ^= Card.GetHashCode();
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
      if (card_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Card);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Result != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Result);
      }
      if (card_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Card);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CardProcessingSvcVerifyAndTokenizeNotPresentCardResponse other) {
      if (other == null) {
        return;
      }
      if (other.Result != 0) {
        Result = other.Result;
      }
      if (other.card_ != null) {
        if (card_ == null) {
          card_ = new global::HOLMS.Types.Money.Cards.CustomerPaymentCardIndicator();
        }
        Card.MergeFrom(other.Card);
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
            result_ = (global::HOLMS.Types.Money.Cards.Transactions.ProcessorTransactionResult) input.ReadEnum();
            break;
          }
          case 18: {
            if (card_ == null) {
              card_ = new global::HOLMS.Types.Money.Cards.CustomerPaymentCardIndicator();
            }
            input.ReadMessage(card_);
            break;
          }
        }
      }
    }

  }

  public sealed partial class MerchantBatchEnumResponse : pb::IMessage<MerchantBatchEnumResponse> {
    private static readonly pb::MessageParser<MerchantBatchEnumResponse> _parser = new pb::MessageParser<MerchantBatchEnumResponse>(() => new MerchantBatchEnumResponse());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<MerchantBatchEnumResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Money.RPC.CardProcessingSvcReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MerchantBatchEnumResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MerchantBatchEnumResponse(MerchantBatchEnumResponse other) : this() {
      batches_ = other.batches_.Clone();
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MerchantBatchEnumResponse Clone() {
      return new MerchantBatchEnumResponse(this);
    }

    /// <summary>Field number for the "batches" field.</summary>
    public const int BatchesFieldNumber = 1;
    private static readonly pb::FieldCodec<global::HOLMS.Types.Money.Cards.Transactions.ClosedMerchantBatch> _repeated_batches_codec
        = pb::FieldCodec.ForMessage(10, global::HOLMS.Types.Money.Cards.Transactions.ClosedMerchantBatch.Parser);
    private readonly pbc::RepeatedField<global::HOLMS.Types.Money.Cards.Transactions.ClosedMerchantBatch> batches_ = new pbc::RepeatedField<global::HOLMS.Types.Money.Cards.Transactions.ClosedMerchantBatch>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::HOLMS.Types.Money.Cards.Transactions.ClosedMerchantBatch> Batches {
      get { return batches_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as MerchantBatchEnumResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(MerchantBatchEnumResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!batches_.Equals(other.batches_)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= batches_.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      batches_.WriteTo(output, _repeated_batches_codec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += batches_.CalculateSize(_repeated_batches_codec);
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(MerchantBatchEnumResponse other) {
      if (other == null) {
        return;
      }
      batches_.Add(other.batches_);
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
            batches_.AddEntriesFrom(input, _repeated_batches_codec);
            break;
          }
        }
      }
    }

  }

  public sealed partial class CardProcessingSvcSearchHistoricalBatchesRequest : pb::IMessage<CardProcessingSvcSearchHistoricalBatchesRequest> {
    private static readonly pb::MessageParser<CardProcessingSvcSearchHistoricalBatchesRequest> _parser = new pb::MessageParser<CardProcessingSvcSearchHistoricalBatchesRequest>(() => new CardProcessingSvcSearchHistoricalBatchesRequest());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CardProcessingSvcSearchHistoricalBatchesRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Money.RPC.CardProcessingSvcReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CardProcessingSvcSearchHistoricalBatchesRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CardProcessingSvcSearchHistoricalBatchesRequest(CardProcessingSvcSearchHistoricalBatchesRequest other) : this() {
      Merchant = other.merchant_ != null ? other.Merchant.Clone() : null;
      SearchRange = other.searchRange_ != null ? other.SearchRange.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CardProcessingSvcSearchHistoricalBatchesRequest Clone() {
      return new CardProcessingSvcSearchHistoricalBatchesRequest(this);
    }

    /// <summary>Field number for the "merchant" field.</summary>
    public const int MerchantFieldNumber = 1;
    private global::HOLMS.Types.Money.Cards.CardMerchantIndicator merchant_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Money.Cards.CardMerchantIndicator Merchant {
      get { return merchant_; }
      set {
        merchant_ = value;
      }
    }

    /// <summary>Field number for the "search_range" field.</summary>
    public const int SearchRangeFieldNumber = 2;
    private global::HOLMS.Types.Primitive.PbInterval searchRange_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Primitive.PbInterval SearchRange {
      get { return searchRange_; }
      set {
        searchRange_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CardProcessingSvcSearchHistoricalBatchesRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CardProcessingSvcSearchHistoricalBatchesRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Merchant, other.Merchant)) return false;
      if (!object.Equals(SearchRange, other.SearchRange)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (merchant_ != null) hash ^= Merchant.GetHashCode();
      if (searchRange_ != null) hash ^= SearchRange.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (merchant_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Merchant);
      }
      if (searchRange_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(SearchRange);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (merchant_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Merchant);
      }
      if (searchRange_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(SearchRange);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CardProcessingSvcSearchHistoricalBatchesRequest other) {
      if (other == null) {
        return;
      }
      if (other.merchant_ != null) {
        if (merchant_ == null) {
          merchant_ = new global::HOLMS.Types.Money.Cards.CardMerchantIndicator();
        }
        Merchant.MergeFrom(other.Merchant);
      }
      if (other.searchRange_ != null) {
        if (searchRange_ == null) {
          searchRange_ = new global::HOLMS.Types.Primitive.PbInterval();
        }
        SearchRange.MergeFrom(other.SearchRange);
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
            if (merchant_ == null) {
              merchant_ = new global::HOLMS.Types.Money.Cards.CardMerchantIndicator();
            }
            input.ReadMessage(merchant_);
            break;
          }
          case 18: {
            if (searchRange_ == null) {
              searchRange_ = new global::HOLMS.Types.Primitive.PbInterval();
            }
            input.ReadMessage(searchRange_);
            break;
          }
        }
      }
    }

  }

  public sealed partial class CardProcessingSvcVoidTransactionResponse : pb::IMessage<CardProcessingSvcVoidTransactionResponse> {
    private static readonly pb::MessageParser<CardProcessingSvcVoidTransactionResponse> _parser = new pb::MessageParser<CardProcessingSvcVoidTransactionResponse>(() => new CardProcessingSvcVoidTransactionResponse());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CardProcessingSvcVoidTransactionResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Money.RPC.CardProcessingSvcReflection.Descriptor.MessageTypes[4]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CardProcessingSvcVoidTransactionResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CardProcessingSvcVoidTransactionResponse(CardProcessingSvcVoidTransactionResponse other) : this() {
      result_ = other.result_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CardProcessingSvcVoidTransactionResponse Clone() {
      return new CardProcessingSvcVoidTransactionResponse(this);
    }

    /// <summary>Field number for the "result" field.</summary>
    public const int ResultFieldNumber = 1;
    private global::HOLMS.Types.Money.RPC.CardProcessingSvcVoidTransactionResult result_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Money.RPC.CardProcessingSvcVoidTransactionResult Result {
      get { return result_; }
      set {
        result_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CardProcessingSvcVoidTransactionResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CardProcessingSvcVoidTransactionResponse other) {
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
    public void MergeFrom(CardProcessingSvcVoidTransactionResponse other) {
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
            result_ = (global::HOLMS.Types.Money.RPC.CardProcessingSvcVoidTransactionResult) input.ReadEnum();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
