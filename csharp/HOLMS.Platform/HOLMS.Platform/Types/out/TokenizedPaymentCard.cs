// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: money/cards/tokenized_payment_card.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HOLMS.Types.Money.Cards {

  /// <summary>Holder for reflection information generated from money/cards/tokenized_payment_card.proto</summary>
  public static partial class TokenizedPaymentCardReflection {

    #region Descriptor
    /// <summary>File descriptor for money/cards/tokenized_payment_card.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TokenizedPaymentCardReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cihtb25leS9jYXJkcy90b2tlbml6ZWRfcGF5bWVudF9jYXJkLnByb3RvEhdo",
            "b2xtcy50eXBlcy5tb25leS5jYXJkcxoobW9uZXkvY2FyZHMvcGF5bWVudF9j",
            "YXJkX2luZGljYXRvci5wcm90bxodcHJpbWl0aXZlL3BiX2xvY2FsX2RhdGUu",
            "cHJvdG8aH3ByaW1pdGl2ZS9tb25ldGFyeV9hbW91bnQucHJvdG8aJG1vbmV5",
            "L2NhcmRzL3BheW1lbnRfY2FyZF9icmFuZC5wcm90byLuAwoUVG9rZW5pemVk",
            "UGF5bWVudENhcmQSQAoJZW50aXR5X2lkGAEgASgLMi0uaG9sbXMudHlwZXMu",
            "bW9uZXkuY2FyZHMuUGF5bWVudENhcmRJbmRpY2F0b3ISEgoKbWFza2VkX3Bh",
            "bhgCIAEoCRI7Cg9leHBpcmF0aW9uX2RhdGUYAyABKAsyIi5ob2xtcy50eXBl",
            "cy5wcmltaXRpdmUuUGJMb2NhbERhdGUSGAoQY2FyZF9ob2xkZXJfbmFtZRgE",
            "IAEoCRI4CgVicmFuZBgFIAEoDjIpLmhvbG1zLnR5cGVzLm1vbmV5LmNhcmRz",
            "LlBheW1lbnRDYXJkQnJhbmQSFwoPaXNfdmlydHVhbF9jYXJkGAYgASgIEkoK",
            "G3ZpcnR1YWxfY2FyZF91bnVzZWRfYmFsYW5jZRgHIAEoCzIlLmhvbG1zLnR5",
            "cGVzLnByaW1pdGl2ZS5Nb25ldGFyeUFtb3VudBJFChl2aXJ0dWFsX2NhcmRf",
            "YXZhaWxhYmxlX29uGAggASgLMiIuaG9sbXMudHlwZXMucHJpbWl0aXZlLlBi",
            "TG9jYWxEYXRlEkMKF3ZpcnR1YWxfY2FyZF9leHBpcmVzX29uGAkgASgLMiIu",
            "aG9sbXMudHlwZXMucHJpbWl0aXZlLlBiTG9jYWxEYXRlQhqqAhdIT0xNUy5U",
            "eXBlcy5Nb25leS5DYXJkc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::HOLMS.Types.Money.Cards.PaymentCardIndicatorReflection.Descriptor, global::HOLMS.Types.Primitive.PbLocalDateReflection.Descriptor, global::HOLMS.Types.Primitive.MonetaryAmountReflection.Descriptor, global::HOLMS.Types.Money.Cards.PaymentCardBrandReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Money.Cards.TokenizedPaymentCard), global::HOLMS.Types.Money.Cards.TokenizedPaymentCard.Parser, new[]{ "EntityId", "MaskedPan", "ExpirationDate", "CardHolderName", "Brand", "IsVirtualCard", "VirtualCardUnusedBalance", "VirtualCardAvailableOn", "VirtualCardExpiresOn" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class TokenizedPaymentCard : pb::IMessage<TokenizedPaymentCard> {
    private static readonly pb::MessageParser<TokenizedPaymentCard> _parser = new pb::MessageParser<TokenizedPaymentCard>(() => new TokenizedPaymentCard());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<TokenizedPaymentCard> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Money.Cards.TokenizedPaymentCardReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TokenizedPaymentCard() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TokenizedPaymentCard(TokenizedPaymentCard other) : this() {
      EntityId = other.entityId_ != null ? other.EntityId.Clone() : null;
      maskedPan_ = other.maskedPan_;
      ExpirationDate = other.expirationDate_ != null ? other.ExpirationDate.Clone() : null;
      cardHolderName_ = other.cardHolderName_;
      brand_ = other.brand_;
      isVirtualCard_ = other.isVirtualCard_;
      VirtualCardUnusedBalance = other.virtualCardUnusedBalance_ != null ? other.VirtualCardUnusedBalance.Clone() : null;
      VirtualCardAvailableOn = other.virtualCardAvailableOn_ != null ? other.VirtualCardAvailableOn.Clone() : null;
      VirtualCardExpiresOn = other.virtualCardExpiresOn_ != null ? other.VirtualCardExpiresOn.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TokenizedPaymentCard Clone() {
      return new TokenizedPaymentCard(this);
    }

    /// <summary>Field number for the "entity_id" field.</summary>
    public const int EntityIdFieldNumber = 1;
    private global::HOLMS.Types.Money.Cards.PaymentCardIndicator entityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Money.Cards.PaymentCardIndicator EntityId {
      get { return entityId_; }
      set {
        entityId_ = value;
      }
    }

    /// <summary>Field number for the "masked_pan" field.</summary>
    public const int MaskedPanFieldNumber = 2;
    private string maskedPan_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string MaskedPan {
      get { return maskedPan_; }
      set {
        maskedPan_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "expiration_date" field.</summary>
    public const int ExpirationDateFieldNumber = 3;
    private global::HOLMS.Types.Primitive.PbLocalDate expirationDate_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Primitive.PbLocalDate ExpirationDate {
      get { return expirationDate_; }
      set {
        expirationDate_ = value;
      }
    }

    /// <summary>Field number for the "card_holder_name" field.</summary>
    public const int CardHolderNameFieldNumber = 4;
    private string cardHolderName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string CardHolderName {
      get { return cardHolderName_; }
      set {
        cardHolderName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "brand" field.</summary>
    public const int BrandFieldNumber = 5;
    private global::HOLMS.Types.Money.Cards.PaymentCardBrand brand_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Money.Cards.PaymentCardBrand Brand {
      get { return brand_; }
      set {
        brand_ = value;
      }
    }

    /// <summary>Field number for the "is_virtual_card" field.</summary>
    public const int IsVirtualCardFieldNumber = 6;
    private bool isVirtualCard_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool IsVirtualCard {
      get { return isVirtualCard_; }
      set {
        isVirtualCard_ = value;
      }
    }

    /// <summary>Field number for the "virtual_card_unused_balance" field.</summary>
    public const int VirtualCardUnusedBalanceFieldNumber = 7;
    private global::HOLMS.Types.Primitive.MonetaryAmount virtualCardUnusedBalance_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Primitive.MonetaryAmount VirtualCardUnusedBalance {
      get { return virtualCardUnusedBalance_; }
      set {
        virtualCardUnusedBalance_ = value;
      }
    }

    /// <summary>Field number for the "virtual_card_available_on" field.</summary>
    public const int VirtualCardAvailableOnFieldNumber = 8;
    private global::HOLMS.Types.Primitive.PbLocalDate virtualCardAvailableOn_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Primitive.PbLocalDate VirtualCardAvailableOn {
      get { return virtualCardAvailableOn_; }
      set {
        virtualCardAvailableOn_ = value;
      }
    }

    /// <summary>Field number for the "virtual_card_expires_on" field.</summary>
    public const int VirtualCardExpiresOnFieldNumber = 9;
    private global::HOLMS.Types.Primitive.PbLocalDate virtualCardExpiresOn_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Primitive.PbLocalDate VirtualCardExpiresOn {
      get { return virtualCardExpiresOn_; }
      set {
        virtualCardExpiresOn_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as TokenizedPaymentCard);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(TokenizedPaymentCard other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(EntityId, other.EntityId)) return false;
      if (MaskedPan != other.MaskedPan) return false;
      if (!object.Equals(ExpirationDate, other.ExpirationDate)) return false;
      if (CardHolderName != other.CardHolderName) return false;
      if (Brand != other.Brand) return false;
      if (IsVirtualCard != other.IsVirtualCard) return false;
      if (!object.Equals(VirtualCardUnusedBalance, other.VirtualCardUnusedBalance)) return false;
      if (!object.Equals(VirtualCardAvailableOn, other.VirtualCardAvailableOn)) return false;
      if (!object.Equals(VirtualCardExpiresOn, other.VirtualCardExpiresOn)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (entityId_ != null) hash ^= EntityId.GetHashCode();
      if (MaskedPan.Length != 0) hash ^= MaskedPan.GetHashCode();
      if (expirationDate_ != null) hash ^= ExpirationDate.GetHashCode();
      if (CardHolderName.Length != 0) hash ^= CardHolderName.GetHashCode();
      if (Brand != 0) hash ^= Brand.GetHashCode();
      if (IsVirtualCard != false) hash ^= IsVirtualCard.GetHashCode();
      if (virtualCardUnusedBalance_ != null) hash ^= VirtualCardUnusedBalance.GetHashCode();
      if (virtualCardAvailableOn_ != null) hash ^= VirtualCardAvailableOn.GetHashCode();
      if (virtualCardExpiresOn_ != null) hash ^= VirtualCardExpiresOn.GetHashCode();
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
      if (MaskedPan.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(MaskedPan);
      }
      if (expirationDate_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(ExpirationDate);
      }
      if (CardHolderName.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(CardHolderName);
      }
      if (Brand != 0) {
        output.WriteRawTag(40);
        output.WriteEnum((int) Brand);
      }
      if (IsVirtualCard != false) {
        output.WriteRawTag(48);
        output.WriteBool(IsVirtualCard);
      }
      if (virtualCardUnusedBalance_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(VirtualCardUnusedBalance);
      }
      if (virtualCardAvailableOn_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(VirtualCardAvailableOn);
      }
      if (virtualCardExpiresOn_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(VirtualCardExpiresOn);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (entityId_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(EntityId);
      }
      if (MaskedPan.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(MaskedPan);
      }
      if (expirationDate_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ExpirationDate);
      }
      if (CardHolderName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(CardHolderName);
      }
      if (Brand != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Brand);
      }
      if (IsVirtualCard != false) {
        size += 1 + 1;
      }
      if (virtualCardUnusedBalance_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(VirtualCardUnusedBalance);
      }
      if (virtualCardAvailableOn_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(VirtualCardAvailableOn);
      }
      if (virtualCardExpiresOn_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(VirtualCardExpiresOn);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(TokenizedPaymentCard other) {
      if (other == null) {
        return;
      }
      if (other.entityId_ != null) {
        if (entityId_ == null) {
          entityId_ = new global::HOLMS.Types.Money.Cards.PaymentCardIndicator();
        }
        EntityId.MergeFrom(other.EntityId);
      }
      if (other.MaskedPan.Length != 0) {
        MaskedPan = other.MaskedPan;
      }
      if (other.expirationDate_ != null) {
        if (expirationDate_ == null) {
          expirationDate_ = new global::HOLMS.Types.Primitive.PbLocalDate();
        }
        ExpirationDate.MergeFrom(other.ExpirationDate);
      }
      if (other.CardHolderName.Length != 0) {
        CardHolderName = other.CardHolderName;
      }
      if (other.Brand != 0) {
        Brand = other.Brand;
      }
      if (other.IsVirtualCard != false) {
        IsVirtualCard = other.IsVirtualCard;
      }
      if (other.virtualCardUnusedBalance_ != null) {
        if (virtualCardUnusedBalance_ == null) {
          virtualCardUnusedBalance_ = new global::HOLMS.Types.Primitive.MonetaryAmount();
        }
        VirtualCardUnusedBalance.MergeFrom(other.VirtualCardUnusedBalance);
      }
      if (other.virtualCardAvailableOn_ != null) {
        if (virtualCardAvailableOn_ == null) {
          virtualCardAvailableOn_ = new global::HOLMS.Types.Primitive.PbLocalDate();
        }
        VirtualCardAvailableOn.MergeFrom(other.VirtualCardAvailableOn);
      }
      if (other.virtualCardExpiresOn_ != null) {
        if (virtualCardExpiresOn_ == null) {
          virtualCardExpiresOn_ = new global::HOLMS.Types.Primitive.PbLocalDate();
        }
        VirtualCardExpiresOn.MergeFrom(other.VirtualCardExpiresOn);
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
              entityId_ = new global::HOLMS.Types.Money.Cards.PaymentCardIndicator();
            }
            input.ReadMessage(entityId_);
            break;
          }
          case 18: {
            MaskedPan = input.ReadString();
            break;
          }
          case 26: {
            if (expirationDate_ == null) {
              expirationDate_ = new global::HOLMS.Types.Primitive.PbLocalDate();
            }
            input.ReadMessage(expirationDate_);
            break;
          }
          case 34: {
            CardHolderName = input.ReadString();
            break;
          }
          case 40: {
            brand_ = (global::HOLMS.Types.Money.Cards.PaymentCardBrand) input.ReadEnum();
            break;
          }
          case 48: {
            IsVirtualCard = input.ReadBool();
            break;
          }
          case 58: {
            if (virtualCardUnusedBalance_ == null) {
              virtualCardUnusedBalance_ = new global::HOLMS.Types.Primitive.MonetaryAmount();
            }
            input.ReadMessage(virtualCardUnusedBalance_);
            break;
          }
          case 66: {
            if (virtualCardAvailableOn_ == null) {
              virtualCardAvailableOn_ = new global::HOLMS.Types.Primitive.PbLocalDate();
            }
            input.ReadMessage(virtualCardAvailableOn_);
            break;
          }
          case 74: {
            if (virtualCardExpiresOn_ == null) {
              virtualCardExpiresOn_ = new global::HOLMS.Types.Primitive.PbLocalDate();
            }
            input.ReadMessage(virtualCardExpiresOn_);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
