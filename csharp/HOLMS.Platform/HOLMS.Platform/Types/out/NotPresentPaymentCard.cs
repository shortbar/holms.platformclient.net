// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: money/cards/not_present_payment_card.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HOLMS.Types.Money.Cards {

  /// <summary>Holder for reflection information generated from money/cards/not_present_payment_card.proto</summary>
  public static partial class NotPresentPaymentCardReflection {

    #region Descriptor
    /// <summary>File descriptor for money/cards/not_present_payment_card.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static NotPresentPaymentCardReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ciptb25leS9jYXJkcy9ub3RfcHJlc2VudF9wYXltZW50X2NhcmQucHJvdG8S",
            "F2hvbG1zLnR5cGVzLm1vbmV5LmNhcmRzGh1wcmltaXRpdmUvcGJfbG9jYWxf",
            "ZGF0ZS5wcm90bxofcHJpbWl0aXZlL21vbmV0YXJ5X2Ftb3VudC5wcm90byKB",
            "AwoVTm90UHJlc2VudFBheW1lbnRDYXJkEhMKC2NhcmRfbnVtYmVyGAEgASgJ",
            "EgsKA2N2YxgCIAEoCRIUCgxleHBpcnlfbW9udGgYAyABKAUSHgoWZm91cl9k",
            "aWdpdF9leHBpcnlfeWVhchgEIAEoBRIPCgd6aXBjb2RlGAUgASgJEhcKD2Nh",
            "cmRob2xkZXJfbmFtZRgGIAEoCRIXCg9pc192aXJ0dWFsX2NhcmQYByABKAgS",
            "QQoSdmlydHVhbF9jYXJkX2xpbWl0GAggASgLMiUuaG9sbXMudHlwZXMucHJp",
            "bWl0aXZlLk1vbmV0YXJ5QW1vdW50EkUKGXZpcnR1YWxfY2FyZF9hdmFpbGFi",
            "bGVfb24YCSABKAsyIi5ob2xtcy50eXBlcy5wcmltaXRpdmUuUGJMb2NhbERh",
            "dGUSQwoXdmlydHVhbF9jYXJkX2V4cGlyZXNfb24YCiABKAsyIi5ob2xtcy50",
            "eXBlcy5wcmltaXRpdmUuUGJMb2NhbERhdGVCJ1oLbW9uZXkvY2FyZHOqAhdI",
            "T0xNUy5UeXBlcy5Nb25leS5DYXJkc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::HOLMS.Types.Primitive.PbLocalDateReflection.Descriptor, global::HOLMS.Types.Primitive.MonetaryAmountReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Money.Cards.NotPresentPaymentCard), global::HOLMS.Types.Money.Cards.NotPresentPaymentCard.Parser, new[]{ "CardNumber", "Cvc", "ExpiryMonth", "FourDigitExpiryYear", "Zipcode", "CardholderName", "IsVirtualCard", "VirtualCardLimit", "VirtualCardAvailableOn", "VirtualCardExpiresOn" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class NotPresentPaymentCard : pb::IMessage<NotPresentPaymentCard> {
    private static readonly pb::MessageParser<NotPresentPaymentCard> _parser = new pb::MessageParser<NotPresentPaymentCard>(() => new NotPresentPaymentCard());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<NotPresentPaymentCard> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Money.Cards.NotPresentPaymentCardReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public NotPresentPaymentCard() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public NotPresentPaymentCard(NotPresentPaymentCard other) : this() {
      cardNumber_ = other.cardNumber_;
      cvc_ = other.cvc_;
      expiryMonth_ = other.expiryMonth_;
      fourDigitExpiryYear_ = other.fourDigitExpiryYear_;
      zipcode_ = other.zipcode_;
      cardholderName_ = other.cardholderName_;
      isVirtualCard_ = other.isVirtualCard_;
      VirtualCardLimit = other.virtualCardLimit_ != null ? other.VirtualCardLimit.Clone() : null;
      VirtualCardAvailableOn = other.virtualCardAvailableOn_ != null ? other.VirtualCardAvailableOn.Clone() : null;
      VirtualCardExpiresOn = other.virtualCardExpiresOn_ != null ? other.VirtualCardExpiresOn.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public NotPresentPaymentCard Clone() {
      return new NotPresentPaymentCard(this);
    }

    /// <summary>Field number for the "card_number" field.</summary>
    public const int CardNumberFieldNumber = 1;
    private string cardNumber_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string CardNumber {
      get { return cardNumber_; }
      set {
        cardNumber_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "cvc" field.</summary>
    public const int CvcFieldNumber = 2;
    private string cvc_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Cvc {
      get { return cvc_; }
      set {
        cvc_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "expiry_month" field.</summary>
    public const int ExpiryMonthFieldNumber = 3;
    private int expiryMonth_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int ExpiryMonth {
      get { return expiryMonth_; }
      set {
        expiryMonth_ = value;
      }
    }

    /// <summary>Field number for the "four_digit_expiry_year" field.</summary>
    public const int FourDigitExpiryYearFieldNumber = 4;
    private int fourDigitExpiryYear_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int FourDigitExpiryYear {
      get { return fourDigitExpiryYear_; }
      set {
        fourDigitExpiryYear_ = value;
      }
    }

    /// <summary>Field number for the "zipcode" field.</summary>
    public const int ZipcodeFieldNumber = 5;
    private string zipcode_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Zipcode {
      get { return zipcode_; }
      set {
        zipcode_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "cardholder_name" field.</summary>
    public const int CardholderNameFieldNumber = 6;
    private string cardholderName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string CardholderName {
      get { return cardholderName_; }
      set {
        cardholderName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "is_virtual_card" field.</summary>
    public const int IsVirtualCardFieldNumber = 7;
    private bool isVirtualCard_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool IsVirtualCard {
      get { return isVirtualCard_; }
      set {
        isVirtualCard_ = value;
      }
    }

    /// <summary>Field number for the "virtual_card_limit" field.</summary>
    public const int VirtualCardLimitFieldNumber = 8;
    private global::HOLMS.Types.Primitive.MonetaryAmount virtualCardLimit_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Primitive.MonetaryAmount VirtualCardLimit {
      get { return virtualCardLimit_; }
      set {
        virtualCardLimit_ = value;
      }
    }

    /// <summary>Field number for the "virtual_card_available_on" field.</summary>
    public const int VirtualCardAvailableOnFieldNumber = 9;
    private global::HOLMS.Types.Primitive.PbLocalDate virtualCardAvailableOn_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Primitive.PbLocalDate VirtualCardAvailableOn {
      get { return virtualCardAvailableOn_; }
      set {
        virtualCardAvailableOn_ = value;
      }
    }

    /// <summary>Field number for the "virtual_card_expires_on" field.</summary>
    public const int VirtualCardExpiresOnFieldNumber = 10;
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
      return Equals(other as NotPresentPaymentCard);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(NotPresentPaymentCard other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (CardNumber != other.CardNumber) return false;
      if (Cvc != other.Cvc) return false;
      if (ExpiryMonth != other.ExpiryMonth) return false;
      if (FourDigitExpiryYear != other.FourDigitExpiryYear) return false;
      if (Zipcode != other.Zipcode) return false;
      if (CardholderName != other.CardholderName) return false;
      if (IsVirtualCard != other.IsVirtualCard) return false;
      if (!object.Equals(VirtualCardLimit, other.VirtualCardLimit)) return false;
      if (!object.Equals(VirtualCardAvailableOn, other.VirtualCardAvailableOn)) return false;
      if (!object.Equals(VirtualCardExpiresOn, other.VirtualCardExpiresOn)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (CardNumber.Length != 0) hash ^= CardNumber.GetHashCode();
      if (Cvc.Length != 0) hash ^= Cvc.GetHashCode();
      if (ExpiryMonth != 0) hash ^= ExpiryMonth.GetHashCode();
      if (FourDigitExpiryYear != 0) hash ^= FourDigitExpiryYear.GetHashCode();
      if (Zipcode.Length != 0) hash ^= Zipcode.GetHashCode();
      if (CardholderName.Length != 0) hash ^= CardholderName.GetHashCode();
      if (IsVirtualCard != false) hash ^= IsVirtualCard.GetHashCode();
      if (virtualCardLimit_ != null) hash ^= VirtualCardLimit.GetHashCode();
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
      if (CardNumber.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(CardNumber);
      }
      if (Cvc.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Cvc);
      }
      if (ExpiryMonth != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(ExpiryMonth);
      }
      if (FourDigitExpiryYear != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(FourDigitExpiryYear);
      }
      if (Zipcode.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(Zipcode);
      }
      if (CardholderName.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(CardholderName);
      }
      if (IsVirtualCard != false) {
        output.WriteRawTag(56);
        output.WriteBool(IsVirtualCard);
      }
      if (virtualCardLimit_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(VirtualCardLimit);
      }
      if (virtualCardAvailableOn_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(VirtualCardAvailableOn);
      }
      if (virtualCardExpiresOn_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(VirtualCardExpiresOn);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (CardNumber.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(CardNumber);
      }
      if (Cvc.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Cvc);
      }
      if (ExpiryMonth != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(ExpiryMonth);
      }
      if (FourDigitExpiryYear != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(FourDigitExpiryYear);
      }
      if (Zipcode.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Zipcode);
      }
      if (CardholderName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(CardholderName);
      }
      if (IsVirtualCard != false) {
        size += 1 + 1;
      }
      if (virtualCardLimit_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(VirtualCardLimit);
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
    public void MergeFrom(NotPresentPaymentCard other) {
      if (other == null) {
        return;
      }
      if (other.CardNumber.Length != 0) {
        CardNumber = other.CardNumber;
      }
      if (other.Cvc.Length != 0) {
        Cvc = other.Cvc;
      }
      if (other.ExpiryMonth != 0) {
        ExpiryMonth = other.ExpiryMonth;
      }
      if (other.FourDigitExpiryYear != 0) {
        FourDigitExpiryYear = other.FourDigitExpiryYear;
      }
      if (other.Zipcode.Length != 0) {
        Zipcode = other.Zipcode;
      }
      if (other.CardholderName.Length != 0) {
        CardholderName = other.CardholderName;
      }
      if (other.IsVirtualCard != false) {
        IsVirtualCard = other.IsVirtualCard;
      }
      if (other.virtualCardLimit_ != null) {
        if (virtualCardLimit_ == null) {
          virtualCardLimit_ = new global::HOLMS.Types.Primitive.MonetaryAmount();
        }
        VirtualCardLimit.MergeFrom(other.VirtualCardLimit);
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
            CardNumber = input.ReadString();
            break;
          }
          case 18: {
            Cvc = input.ReadString();
            break;
          }
          case 24: {
            ExpiryMonth = input.ReadInt32();
            break;
          }
          case 32: {
            FourDigitExpiryYear = input.ReadInt32();
            break;
          }
          case 42: {
            Zipcode = input.ReadString();
            break;
          }
          case 50: {
            CardholderName = input.ReadString();
            break;
          }
          case 56: {
            IsVirtualCard = input.ReadBool();
            break;
          }
          case 66: {
            if (virtualCardLimit_ == null) {
              virtualCardLimit_ = new global::HOLMS.Types.Primitive.MonetaryAmount();
            }
            input.ReadMessage(virtualCardLimit_);
            break;
          }
          case 74: {
            if (virtualCardAvailableOn_ == null) {
              virtualCardAvailableOn_ = new global::HOLMS.Types.Primitive.PbLocalDate();
            }
            input.ReadMessage(virtualCardAvailableOn_);
            break;
          }
          case 82: {
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
