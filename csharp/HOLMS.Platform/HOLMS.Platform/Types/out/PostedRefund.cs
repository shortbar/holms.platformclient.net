// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: folio/posted_refund.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HOLMS.Types.Folio {

  /// <summary>Holder for reflection information generated from folio/posted_refund.proto</summary>
  public static partial class PostedRefundReflection {

    #region Descriptor
    /// <summary>File descriptor for folio/posted_refund.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PostedRefundReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Chlmb2xpby9wb3N0ZWRfcmVmdW5kLnByb3RvEhFob2xtcy50eXBlcy5mb2xp",
            "bxofZ29vZ2xlL3Byb3RvYnVmL3RpbWVzdGFtcC5wcm90bxofcHJpbWl0aXZl",
            "L21vbmV0YXJ5X2Ftb3VudC5wcm90byKHAQoMUG9zdGVkUmVmdW5kEi0KCXBv",
            "c3RlZF9hdBgBIAEoCzIaLmdvb2dsZS5wcm90b2J1Zi5UaW1lc3RhbXASNQoG",
            "YW1vdW50GAIgASgLMiUuaG9sbXMudHlwZXMucHJpbWl0aXZlLk1vbmV0YXJ5",
            "QW1vdW50EhEKCW5hcnJhdGlvbhgDIAEoCUIbWgVmb2xpb6oCEUhPTE1TLlR5",
            "cGVzLkZvbGlvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, global::HOLMS.Types.Primitive.MonetaryAmountReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Folio.PostedRefund), global::HOLMS.Types.Folio.PostedRefund.Parser, new[]{ "PostedAt", "Amount", "Narration" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class PostedRefund : pb::IMessage<PostedRefund> {
    private static readonly pb::MessageParser<PostedRefund> _parser = new pb::MessageParser<PostedRefund>(() => new PostedRefund());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PostedRefund> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Folio.PostedRefundReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PostedRefund() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PostedRefund(PostedRefund other) : this() {
      PostedAt = other.postedAt_ != null ? other.PostedAt.Clone() : null;
      Amount = other.amount_ != null ? other.Amount.Clone() : null;
      narration_ = other.narration_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PostedRefund Clone() {
      return new PostedRefund(this);
    }

    /// <summary>Field number for the "posted_at" field.</summary>
    public const int PostedAtFieldNumber = 1;
    private global::Google.Protobuf.WellKnownTypes.Timestamp postedAt_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Timestamp PostedAt {
      get { return postedAt_; }
      set {
        postedAt_ = value;
      }
    }

    /// <summary>Field number for the "amount" field.</summary>
    public const int AmountFieldNumber = 2;
    private global::HOLMS.Types.Primitive.MonetaryAmount amount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Primitive.MonetaryAmount Amount {
      get { return amount_; }
      set {
        amount_ = value;
      }
    }

    /// <summary>Field number for the "narration" field.</summary>
    public const int NarrationFieldNumber = 3;
    private string narration_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Narration {
      get { return narration_; }
      set {
        narration_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PostedRefund);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PostedRefund other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(PostedAt, other.PostedAt)) return false;
      if (!object.Equals(Amount, other.Amount)) return false;
      if (Narration != other.Narration) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (postedAt_ != null) hash ^= PostedAt.GetHashCode();
      if (amount_ != null) hash ^= Amount.GetHashCode();
      if (Narration.Length != 0) hash ^= Narration.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (postedAt_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(PostedAt);
      }
      if (amount_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Amount);
      }
      if (Narration.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Narration);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (postedAt_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(PostedAt);
      }
      if (amount_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Amount);
      }
      if (Narration.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Narration);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PostedRefund other) {
      if (other == null) {
        return;
      }
      if (other.postedAt_ != null) {
        if (postedAt_ == null) {
          postedAt_ = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        PostedAt.MergeFrom(other.PostedAt);
      }
      if (other.amount_ != null) {
        if (amount_ == null) {
          amount_ = new global::HOLMS.Types.Primitive.MonetaryAmount();
        }
        Amount.MergeFrom(other.Amount);
      }
      if (other.Narration.Length != 0) {
        Narration = other.Narration;
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
            if (postedAt_ == null) {
              postedAt_ = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(postedAt_);
            break;
          }
          case 18: {
            if (amount_ == null) {
              amount_ = new global::HOLMS.Types.Primitive.MonetaryAmount();
            }
            input.ReadMessage(amount_);
            break;
          }
          case 26: {
            Narration = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
