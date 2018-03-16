// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: folio/rpc/folio_svc_get_on_file_cards_response.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HOLMS.Types.Folio.RPC {

  /// <summary>Holder for reflection information generated from folio/rpc/folio_svc_get_on_file_cards_response.proto</summary>
  public static partial class FolioSvcGetOnFileCardsResponseReflection {

    #region Descriptor
    /// <summary>File descriptor for folio/rpc/folio_svc_get_on_file_cards_response.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FolioSvcGetOnFileCardsResponseReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjRmb2xpby9ycGMvZm9saW9fc3ZjX2dldF9vbl9maWxlX2NhcmRzX3Jlc3Bv",
            "bnNlLnByb3RvEhVob2xtcy50eXBlcy5mb2xpby5ycGMaJ21vbmV5L2NhcmRz",
            "L2N1c3RvbWVyX3BheW1lbnRfY2FyZC5wcm90byJdCh5Gb2xpb1N2Y0dldE9u",
            "RmlsZUNhcmRzUmVzcG9uc2USOwoFY2FyZHMYASADKAsyLC5ob2xtcy50eXBl",
            "cy5tb25leS5jYXJkcy5DdXN0b21lclBheW1lbnRDYXJkQhiqAhVIT0xNUy5U",
            "eXBlcy5Gb2xpby5SUENiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::HOLMS.Types.Money.Cards.CustomerPaymentCardReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Folio.RPC.FolioSvcGetOnFileCardsResponse), global::HOLMS.Types.Folio.RPC.FolioSvcGetOnFileCardsResponse.Parser, new[]{ "Cards" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class FolioSvcGetOnFileCardsResponse : pb::IMessage<FolioSvcGetOnFileCardsResponse> {
    private static readonly pb::MessageParser<FolioSvcGetOnFileCardsResponse> _parser = new pb::MessageParser<FolioSvcGetOnFileCardsResponse>(() => new FolioSvcGetOnFileCardsResponse());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<FolioSvcGetOnFileCardsResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Folio.RPC.FolioSvcGetOnFileCardsResponseReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FolioSvcGetOnFileCardsResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FolioSvcGetOnFileCardsResponse(FolioSvcGetOnFileCardsResponse other) : this() {
      cards_ = other.cards_.Clone();
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FolioSvcGetOnFileCardsResponse Clone() {
      return new FolioSvcGetOnFileCardsResponse(this);
    }

    /// <summary>Field number for the "cards" field.</summary>
    public const int CardsFieldNumber = 1;
    private static readonly pb::FieldCodec<global::HOLMS.Types.Money.Cards.CustomerPaymentCard> _repeated_cards_codec
        = pb::FieldCodec.ForMessage(10, global::HOLMS.Types.Money.Cards.CustomerPaymentCard.Parser);
    private readonly pbc::RepeatedField<global::HOLMS.Types.Money.Cards.CustomerPaymentCard> cards_ = new pbc::RepeatedField<global::HOLMS.Types.Money.Cards.CustomerPaymentCard>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::HOLMS.Types.Money.Cards.CustomerPaymentCard> Cards {
      get { return cards_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as FolioSvcGetOnFileCardsResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(FolioSvcGetOnFileCardsResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!cards_.Equals(other.cards_)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= cards_.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      cards_.WriteTo(output, _repeated_cards_codec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += cards_.CalculateSize(_repeated_cards_codec);
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(FolioSvcGetOnFileCardsResponse other) {
      if (other == null) {
        return;
      }
      cards_.Add(other.cards_);
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
            cards_.AddEntriesFrom(input, _repeated_cards_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
