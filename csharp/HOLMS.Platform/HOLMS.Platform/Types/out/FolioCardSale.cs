// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: folio/fsv2/folio_card_sale.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HOLMS.Types.Folio.FSv2 {

  /// <summary>Holder for reflection information generated from folio/fsv2/folio_card_sale.proto</summary>
  public static partial class FolioCardSaleReflection {

    #region Descriptor
    /// <summary>File descriptor for folio/fsv2/folio_card_sale.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FolioCardSaleReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiBmb2xpby9mc3YyL2ZvbGlvX2NhcmRfc2FsZS5wcm90bxIWaG9sbXMudHlw",
            "ZXMuZm9saW8uZnN2MhooZm9saW8vZnN2Mi9mb2xpb19jYXJkX3NhbGVfcHVy",
            "cG9zZS5wcm90bxopZm9saW8vZnN2Mi9mb2xpb19ndWVzdF9wYXltZW50X2Nh",
            "cmQucHJvdG8aH2dvb2dsZS9wcm90b2J1Zi90aW1lc3RhbXAucHJvdG8aOW1v",
            "bmV5L2NhcmRzL3RyYW5zYWN0aW9ucy9hdXRob3JpemF0aW9uX2VudHJ5X21l",
            "dGhvZC5wcm90bxoubW9uZXkvY2FyZHMvdHJhbnNhY3Rpb25zL2NhcmRfc2Fs",
            "ZV9zdGF0ZS5wcm90bxo6bW9uZXkvY2FyZHMvdHJhbnNhY3Rpb25zL3BheW1l",
            "bnRfY2FyZF9zYWxlX2luZGljYXRvci5wcm90bxofcHJpbWl0aXZlL21vbmV0",
            "YXJ5X2Ftb3VudC5wcm90byL9BAoNRm9saW9DYXJkU2FsZRJMCgRzYWxlGAEg",
            "ASgLMj4uaG9sbXMudHlwZXMubW9uZXkuY2FyZHMudHJhbnNhY3Rpb25zLlBh",
            "eW1lbnRDYXJkU2FsZUluZGljYXRvchI7CgRjYXJkGAIgASgLMi0uaG9sbXMu",
            "dHlwZXMuZm9saW8uZnN2Mi5Gb2xpb0d1ZXN0UGF5bWVudENhcmQSPQoHcHVy",
            "cG9zZRgDIAEoDjIsLmhvbG1zLnR5cGVzLmZvbGlvLmZzdjIuRm9saW9DYXJk",
            "U2FsZVB1cnBvc2USRwoKc2FsZV9zdGF0ZRgEIAEoDjIzLmhvbG1zLnR5cGVz",
            "Lm1vbmV5LmNhcmRzLnRyYW5zYWN0aW9ucy5DYXJkU2FsZVN0YXRlEj4KD29w",
            "ZW5fYXV0aG9yaXplZBgFIAEoCzIlLmhvbG1zLnR5cGVzLnByaW1pdGl2ZS5N",
            "b25ldGFyeUFtb3VudBI3CghjYXB0dXJlZBgGIAEoCzIlLmhvbG1zLnR5cGVz",
            "LnByaW1pdGl2ZS5Nb25ldGFyeUFtb3VudBJUCgxlbnRyeV9tZXRob2QYByAB",
            "KA4yPi5ob2xtcy50eXBlcy5tb25leS5jYXJkcy50cmFuc2FjdGlvbnMuQXV0",
            "aG9yaXphdGlvbkVudHJ5TWV0aG9kEi0KCW9wZW5lZF9hdBgIIAEoCzIaLmdv",
            "b2dsZS5wcm90b2J1Zi5UaW1lc3RhbXASGQoRYXBwbGljYXRpb25fbGFiZWwY",
            "CSABKAkSDQoFYV9pX2QYCiABKAkSGgoSYXBwbGljYXRpb25fY3J5cHRvGAsg",
            "ASgJEhUKDWFwcHJvdmFsX2NvZGUYDCABKAlCGaoCFkhPTE1TLlR5cGVzLkZv",
            "bGlvLkZTdjJiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::HOLMS.Types.Folio.FSv2.FolioCardSalePurposeReflection.Descriptor, global::HOLMS.Types.Folio.FSv2.FolioGuestPaymentCardReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, global::HOLMS.Types.Money.Cards.Transactions.AuthorizationEntryMethodReflection.Descriptor, global::HOLMS.Types.Money.Cards.Transactions.CardSaleStateReflection.Descriptor, global::HOLMS.Types.Money.Cards.Transactions.PaymentCardSaleIndicatorReflection.Descriptor, global::HOLMS.Types.Primitive.MonetaryAmountReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Folio.FSv2.FolioCardSale), global::HOLMS.Types.Folio.FSv2.FolioCardSale.Parser, new[]{ "Sale", "Card", "Purpose", "SaleState", "OpenAuthorized", "Captured", "EntryMethod", "OpenedAt", "ApplicationLabel", "AID", "ApplicationCrypto", "ApprovalCode" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class FolioCardSale : pb::IMessage<FolioCardSale> {
    private static readonly pb::MessageParser<FolioCardSale> _parser = new pb::MessageParser<FolioCardSale>(() => new FolioCardSale());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<FolioCardSale> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Folio.FSv2.FolioCardSaleReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FolioCardSale() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FolioCardSale(FolioCardSale other) : this() {
      Sale = other.sale_ != null ? other.Sale.Clone() : null;
      Card = other.card_ != null ? other.Card.Clone() : null;
      purpose_ = other.purpose_;
      saleState_ = other.saleState_;
      OpenAuthorized = other.openAuthorized_ != null ? other.OpenAuthorized.Clone() : null;
      Captured = other.captured_ != null ? other.Captured.Clone() : null;
      entryMethod_ = other.entryMethod_;
      OpenedAt = other.openedAt_ != null ? other.OpenedAt.Clone() : null;
      applicationLabel_ = other.applicationLabel_;
      aID_ = other.aID_;
      applicationCrypto_ = other.applicationCrypto_;
      approvalCode_ = other.approvalCode_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FolioCardSale Clone() {
      return new FolioCardSale(this);
    }

    /// <summary>Field number for the "sale" field.</summary>
    public const int SaleFieldNumber = 1;
    private global::HOLMS.Types.Money.Cards.Transactions.PaymentCardSaleIndicator sale_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Money.Cards.Transactions.PaymentCardSaleIndicator Sale {
      get { return sale_; }
      set {
        sale_ = value;
      }
    }

    /// <summary>Field number for the "card" field.</summary>
    public const int CardFieldNumber = 2;
    private global::HOLMS.Types.Folio.FSv2.FolioGuestPaymentCard card_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Folio.FSv2.FolioGuestPaymentCard Card {
      get { return card_; }
      set {
        card_ = value;
      }
    }

    /// <summary>Field number for the "purpose" field.</summary>
    public const int PurposeFieldNumber = 3;
    private global::HOLMS.Types.Folio.FSv2.FolioCardSalePurpose purpose_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Folio.FSv2.FolioCardSalePurpose Purpose {
      get { return purpose_; }
      set {
        purpose_ = value;
      }
    }

    /// <summary>Field number for the "sale_state" field.</summary>
    public const int SaleStateFieldNumber = 4;
    private global::HOLMS.Types.Money.Cards.Transactions.CardSaleState saleState_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Money.Cards.Transactions.CardSaleState SaleState {
      get { return saleState_; }
      set {
        saleState_ = value;
      }
    }

    /// <summary>Field number for the "open_authorized" field.</summary>
    public const int OpenAuthorizedFieldNumber = 5;
    private global::HOLMS.Types.Primitive.MonetaryAmount openAuthorized_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Primitive.MonetaryAmount OpenAuthorized {
      get { return openAuthorized_; }
      set {
        openAuthorized_ = value;
      }
    }

    /// <summary>Field number for the "captured" field.</summary>
    public const int CapturedFieldNumber = 6;
    private global::HOLMS.Types.Primitive.MonetaryAmount captured_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Primitive.MonetaryAmount Captured {
      get { return captured_; }
      set {
        captured_ = value;
      }
    }

    /// <summary>Field number for the "entry_method" field.</summary>
    public const int EntryMethodFieldNumber = 7;
    private global::HOLMS.Types.Money.Cards.Transactions.AuthorizationEntryMethod entryMethod_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Money.Cards.Transactions.AuthorizationEntryMethod EntryMethod {
      get { return entryMethod_; }
      set {
        entryMethod_ = value;
      }
    }

    /// <summary>Field number for the "opened_at" field.</summary>
    public const int OpenedAtFieldNumber = 8;
    private global::Google.Protobuf.WellKnownTypes.Timestamp openedAt_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Timestamp OpenedAt {
      get { return openedAt_; }
      set {
        openedAt_ = value;
      }
    }

    /// <summary>Field number for the "application_label" field.</summary>
    public const int ApplicationLabelFieldNumber = 9;
    private string applicationLabel_ = "";
    /// <summary>
    ///  Card network stuff
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ApplicationLabel {
      get { return applicationLabel_; }
      set {
        applicationLabel_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "a_i_d" field.</summary>
    public const int AIDFieldNumber = 10;
    private string aID_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string AID {
      get { return aID_; }
      set {
        aID_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "application_crypto" field.</summary>
    public const int ApplicationCryptoFieldNumber = 11;
    private string applicationCrypto_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ApplicationCrypto {
      get { return applicationCrypto_; }
      set {
        applicationCrypto_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "approval_code" field.</summary>
    public const int ApprovalCodeFieldNumber = 12;
    private string approvalCode_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ApprovalCode {
      get { return approvalCode_; }
      set {
        approvalCode_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as FolioCardSale);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(FolioCardSale other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Sale, other.Sale)) return false;
      if (!object.Equals(Card, other.Card)) return false;
      if (Purpose != other.Purpose) return false;
      if (SaleState != other.SaleState) return false;
      if (!object.Equals(OpenAuthorized, other.OpenAuthorized)) return false;
      if (!object.Equals(Captured, other.Captured)) return false;
      if (EntryMethod != other.EntryMethod) return false;
      if (!object.Equals(OpenedAt, other.OpenedAt)) return false;
      if (ApplicationLabel != other.ApplicationLabel) return false;
      if (AID != other.AID) return false;
      if (ApplicationCrypto != other.ApplicationCrypto) return false;
      if (ApprovalCode != other.ApprovalCode) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (sale_ != null) hash ^= Sale.GetHashCode();
      if (card_ != null) hash ^= Card.GetHashCode();
      if (Purpose != 0) hash ^= Purpose.GetHashCode();
      if (SaleState != 0) hash ^= SaleState.GetHashCode();
      if (openAuthorized_ != null) hash ^= OpenAuthorized.GetHashCode();
      if (captured_ != null) hash ^= Captured.GetHashCode();
      if (EntryMethod != 0) hash ^= EntryMethod.GetHashCode();
      if (openedAt_ != null) hash ^= OpenedAt.GetHashCode();
      if (ApplicationLabel.Length != 0) hash ^= ApplicationLabel.GetHashCode();
      if (AID.Length != 0) hash ^= AID.GetHashCode();
      if (ApplicationCrypto.Length != 0) hash ^= ApplicationCrypto.GetHashCode();
      if (ApprovalCode.Length != 0) hash ^= ApprovalCode.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (sale_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Sale);
      }
      if (card_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Card);
      }
      if (Purpose != 0) {
        output.WriteRawTag(24);
        output.WriteEnum((int) Purpose);
      }
      if (SaleState != 0) {
        output.WriteRawTag(32);
        output.WriteEnum((int) SaleState);
      }
      if (openAuthorized_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(OpenAuthorized);
      }
      if (captured_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(Captured);
      }
      if (EntryMethod != 0) {
        output.WriteRawTag(56);
        output.WriteEnum((int) EntryMethod);
      }
      if (openedAt_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(OpenedAt);
      }
      if (ApplicationLabel.Length != 0) {
        output.WriteRawTag(74);
        output.WriteString(ApplicationLabel);
      }
      if (AID.Length != 0) {
        output.WriteRawTag(82);
        output.WriteString(AID);
      }
      if (ApplicationCrypto.Length != 0) {
        output.WriteRawTag(90);
        output.WriteString(ApplicationCrypto);
      }
      if (ApprovalCode.Length != 0) {
        output.WriteRawTag(98);
        output.WriteString(ApprovalCode);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (sale_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Sale);
      }
      if (card_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Card);
      }
      if (Purpose != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Purpose);
      }
      if (SaleState != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) SaleState);
      }
      if (openAuthorized_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(OpenAuthorized);
      }
      if (captured_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Captured);
      }
      if (EntryMethod != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) EntryMethod);
      }
      if (openedAt_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(OpenedAt);
      }
      if (ApplicationLabel.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ApplicationLabel);
      }
      if (AID.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(AID);
      }
      if (ApplicationCrypto.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ApplicationCrypto);
      }
      if (ApprovalCode.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ApprovalCode);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(FolioCardSale other) {
      if (other == null) {
        return;
      }
      if (other.sale_ != null) {
        if (sale_ == null) {
          sale_ = new global::HOLMS.Types.Money.Cards.Transactions.PaymentCardSaleIndicator();
        }
        Sale.MergeFrom(other.Sale);
      }
      if (other.card_ != null) {
        if (card_ == null) {
          card_ = new global::HOLMS.Types.Folio.FSv2.FolioGuestPaymentCard();
        }
        Card.MergeFrom(other.Card);
      }
      if (other.Purpose != 0) {
        Purpose = other.Purpose;
      }
      if (other.SaleState != 0) {
        SaleState = other.SaleState;
      }
      if (other.openAuthorized_ != null) {
        if (openAuthorized_ == null) {
          openAuthorized_ = new global::HOLMS.Types.Primitive.MonetaryAmount();
        }
        OpenAuthorized.MergeFrom(other.OpenAuthorized);
      }
      if (other.captured_ != null) {
        if (captured_ == null) {
          captured_ = new global::HOLMS.Types.Primitive.MonetaryAmount();
        }
        Captured.MergeFrom(other.Captured);
      }
      if (other.EntryMethod != 0) {
        EntryMethod = other.EntryMethod;
      }
      if (other.openedAt_ != null) {
        if (openedAt_ == null) {
          openedAt_ = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        OpenedAt.MergeFrom(other.OpenedAt);
      }
      if (other.ApplicationLabel.Length != 0) {
        ApplicationLabel = other.ApplicationLabel;
      }
      if (other.AID.Length != 0) {
        AID = other.AID;
      }
      if (other.ApplicationCrypto.Length != 0) {
        ApplicationCrypto = other.ApplicationCrypto;
      }
      if (other.ApprovalCode.Length != 0) {
        ApprovalCode = other.ApprovalCode;
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
            if (sale_ == null) {
              sale_ = new global::HOLMS.Types.Money.Cards.Transactions.PaymentCardSaleIndicator();
            }
            input.ReadMessage(sale_);
            break;
          }
          case 18: {
            if (card_ == null) {
              card_ = new global::HOLMS.Types.Folio.FSv2.FolioGuestPaymentCard();
            }
            input.ReadMessage(card_);
            break;
          }
          case 24: {
            purpose_ = (global::HOLMS.Types.Folio.FSv2.FolioCardSalePurpose) input.ReadEnum();
            break;
          }
          case 32: {
            saleState_ = (global::HOLMS.Types.Money.Cards.Transactions.CardSaleState) input.ReadEnum();
            break;
          }
          case 42: {
            if (openAuthorized_ == null) {
              openAuthorized_ = new global::HOLMS.Types.Primitive.MonetaryAmount();
            }
            input.ReadMessage(openAuthorized_);
            break;
          }
          case 50: {
            if (captured_ == null) {
              captured_ = new global::HOLMS.Types.Primitive.MonetaryAmount();
            }
            input.ReadMessage(captured_);
            break;
          }
          case 56: {
            entryMethod_ = (global::HOLMS.Types.Money.Cards.Transactions.AuthorizationEntryMethod) input.ReadEnum();
            break;
          }
          case 66: {
            if (openedAt_ == null) {
              openedAt_ = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(openedAt_);
            break;
          }
          case 74: {
            ApplicationLabel = input.ReadString();
            break;
          }
          case 82: {
            AID = input.ReadString();
            break;
          }
          case 90: {
            ApplicationCrypto = input.ReadString();
            break;
          }
          case 98: {
            ApprovalCode = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
