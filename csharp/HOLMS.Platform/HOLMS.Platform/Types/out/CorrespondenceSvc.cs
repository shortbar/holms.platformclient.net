// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: crm/rpc/correspondence_svc.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HOLMS.Types.CRM.RPC {

  /// <summary>Holder for reflection information generated from crm/rpc/correspondence_svc.proto</summary>
  public static partial class CorrespondenceSvcReflection {

    #region Descriptor
    /// <summary>File descriptor for crm/rpc/correspondence_svc.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CorrespondenceSvcReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiBjcm0vcnBjL2NvcnJlc3BvbmRlbmNlX3N2Yy5wcm90bxITaG9sbXMudHlw",
            "ZXMuY3JtLnJwYxowYm9va2luZy9pbmRpY2F0b3JzL2dyb3VwX2Jvb2tpbmdf",
            "aW5kaWNhdG9yLnByb3RvGi5ib29raW5nL2luZGljYXRvcnMvcmVzZXJ2YXRp",
            "b25faW5kaWNhdG9yLnByb3RvGjVib29raW5nL3Jlc2VydmF0aW9ucy9yZXNl",
            "cnZhdGlvbl9jb250YWN0X3BlcnNvbi5wcm90bxogY3JtL2d1ZXN0cy9ndWVz",
            "dF9pbmRpY2F0b3IucHJvdG8aG2dvb2dsZS9wcm90b2J1Zi9lbXB0eS5wcm90",
            "bxodcHJpbWl0aXZlL3BiX2xvY2FsX2RhdGUucHJvdG8aMXRlbmFuY3lfY29u",
            "ZmlnL3Byb3BlcnR5X2Fycml2YWxfbGV0dGVyX3RleHQucHJvdG8aNnRlbmFu",
            "Y3lfY29uZmlnL3Byb3BlcnR5X2NhbmNlbGxhdGlvbl9sZXR0ZXJfdGV4dC5w",
            "cm90bxo2dGVuYW5jeV9jb25maWcvcHJvcGVydHlfY29uZmlybWF0aW9uX2xl",
            "dHRlcl90ZXh0LnByb3RvIugBChVDb3JyZXNwb25kZW5jZVJlcXVlc3QSSQoL",
            "cmVzZXJ2YXRpb24YASABKAsyNC5ob2xtcy50eXBlcy5ib29raW5nLmluZGlj",
            "YXRvcnMuUmVzZXJ2YXRpb25JbmRpY2F0b3ISNgoGZ3Vlc3RzGAIgAygLMiYu",
            "aG9sbXMudHlwZXMuY3JtLmd1ZXN0cy5HdWVzdEluZGljYXRvchJMCghjb250",
            "YWN0cxgDIAMoCzI6LmhvbG1zLnR5cGVzLmJvb2tpbmcucmVzZXJ2YXRpb25z",
            "LlJlc2VydmF0aW9uQ29udGFjdFBlcnNvbiI5CiVDb3JyZXNwb25kZW5jZVNl",
            "cnZpY2VEb2N1bWVudFJlc3BvbnNlEhAKCGRvY3VtZW50GAEgASgJMsoMChFD",
            "b3JyZXNwb25kZW5jZVN2YxJcChZTZW5kQ29uZmlybWF0aW9uTGV0dGVyEiou",
            "aG9sbXMudHlwZXMuY3JtLnJwYy5Db3JyZXNwb25kZW5jZVJlcXVlc3QaFi5n",
            "b29nbGUucHJvdG9idWYuRW1wdHkSWwoVU2VuZENhbmNlbGxhdGlvbkVtYWls",
            "EiouaG9sbXMudHlwZXMuY3JtLnJwYy5Db3JyZXNwb25kZW5jZVJlcXVlc3Qa",
            "Fi5nb29nbGUucHJvdG9idWYuRW1wdHkSVAoOU2VuZEd1ZXN0Rm9saW8SKi5o",
            "b2xtcy50eXBlcy5jcm0ucnBjLkNvcnJlc3BvbmRlbmNlUmVxdWVzdBoWLmdv",
            "b2dsZS5wcm90b2J1Zi5FbXB0eRKJAQoUUHJldmlld0Fycml2YWxMZXR0ZXIS",
            "NS5ob2xtcy50eXBlcy50ZW5hbmN5X2NvbmZpZy5Qcm9wZXJ0eUFycml2YWxM",
            "ZXR0ZXJUZXh0GjouaG9sbXMudHlwZXMuY3JtLnJwYy5Db3JyZXNwb25kZW5j",
            "ZVNlcnZpY2VEb2N1bWVudFJlc3BvbnNlEoUBCiNHZXRBcnJpdmFsTGV0dGVy",
            "RG9jdW1lbnRzQXJyaXZpbmdPbhIiLmhvbG1zLnR5cGVzLnByaW1pdGl2ZS5Q",
            "YkxvY2FsRGF0ZRo6LmhvbG1zLnR5cGVzLmNybS5ycGMuQ29ycmVzcG9uZGVu",
            "Y2VTZXJ2aWNlRG9jdW1lbnRSZXNwb25zZRKMAQoYR2V0QXJyaXZhbExldHRl",
            "ckRvY3VtZW50EjQuaG9sbXMudHlwZXMuYm9va2luZy5pbmRpY2F0b3JzLlJl",
            "c2VydmF0aW9uSW5kaWNhdG9yGjouaG9sbXMudHlwZXMuY3JtLnJwYy5Db3Jy",
            "ZXNwb25kZW5jZVNlcnZpY2VEb2N1bWVudFJlc3BvbnNlEpYBCiFHZXRCb29r",
            "aW5nQXNzb2NpYXRlZEZvbGlvc1N1bW1hcnkSNS5ob2xtcy50eXBlcy5ib29r",
            "aW5nLmluZGljYXRvcnMuR3JvdXBCb29raW5nSW5kaWNhdG9yGjouaG9sbXMu",
            "dHlwZXMuY3JtLnJwYy5Db3JyZXNwb25kZW5jZVNlcnZpY2VEb2N1bWVudFJl",
            "c3BvbnNlEpMBChlQcmV2aWV3Q29uZmlybWF0aW9uTGV0dGVyEjouaG9sbXMu",
            "dHlwZXMudGVuYW5jeV9jb25maWcuUHJvcGVydHlDb25maXJtYXRpb25MZXR0",
            "ZXJUZXh0GjouaG9sbXMudHlwZXMuY3JtLnJwYy5Db3JyZXNwb25kZW5jZVNl",
            "cnZpY2VEb2N1bWVudFJlc3BvbnNlEpIBChhQcmV2aWV3Q2FuY2VsbGF0aW9u",
            "RW1haWwSOi5ob2xtcy50eXBlcy50ZW5hbmN5X2NvbmZpZy5Qcm9wZXJ0eUNh",
            "bmNlbGxhdGlvbkxldHRlclRleHQaOi5ob2xtcy50eXBlcy5jcm0ucnBjLkNv",
            "cnJlc3BvbmRlbmNlU2VydmljZURvY3VtZW50UmVzcG9uc2USjwEKG0dldFJl",
            "c2VydmF0aW9uRm9saW9QcmludERvYxI0LmhvbG1zLnR5cGVzLmJvb2tpbmcu",
            "aW5kaWNhdG9ycy5SZXNlcnZhdGlvbkluZGljYXRvcho6LmhvbG1zLnR5cGVz",
            "LmNybS5ycGMuQ29ycmVzcG9uZGVuY2VTZXJ2aWNlRG9jdW1lbnRSZXNwb25z",
            "ZRKRAQocR2V0R3JvdXBCb29raW5nRm9saW9QcmludERvYxI1LmhvbG1zLnR5",
            "cGVzLmJvb2tpbmcuaW5kaWNhdG9ycy5Hcm91cEJvb2tpbmdJbmRpY2F0b3Ia",
            "Oi5ob2xtcy50eXBlcy5jcm0ucnBjLkNvcnJlc3BvbmRlbmNlU2VydmljZURv",
            "Y3VtZW50UmVzcG9uc2USlgEKIkdldFJlc2VydmF0aW9uQ29uZmlybWF0aW9u",
            "UHJpbnREb2MSNC5ob2xtcy50eXBlcy5ib29raW5nLmluZGljYXRvcnMuUmVz",
            "ZXJ2YXRpb25JbmRpY2F0b3IaOi5ob2xtcy50eXBlcy5jcm0ucnBjLkNvcnJl",
            "c3BvbmRlbmNlU2VydmljZURvY3VtZW50UmVzcG9uc2VCFqoCE0hPTE1TLlR5",
            "cGVzLkNSTS5SUENiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::HOLMS.Types.Booking.Indicators.GroupBookingIndicatorReflection.Descriptor, global::HOLMS.Types.Booking.Indicators.ReservationIndicatorReflection.Descriptor, global::HOLMS.Types.Booking.Reservations.ReservationContactPersonReflection.Descriptor, global::HOLMS.Types.CRM.Guests.GuestIndicatorReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.EmptyReflection.Descriptor, global::HOLMS.Types.Primitive.PbLocalDateReflection.Descriptor, global::HOLMS.Types.TenancyConfig.PropertyArrivalLetterTextReflection.Descriptor, global::HOLMS.Types.TenancyConfig.PropertyCancellationLetterTextReflection.Descriptor, global::HOLMS.Types.TenancyConfig.PropertyConfirmationLetterTextReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.CRM.RPC.CorrespondenceRequest), global::HOLMS.Types.CRM.RPC.CorrespondenceRequest.Parser, new[]{ "Reservation", "Guests", "Contacts" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.CRM.RPC.CorrespondenceServiceDocumentResponse), global::HOLMS.Types.CRM.RPC.CorrespondenceServiceDocumentResponse.Parser, new[]{ "Document" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class CorrespondenceRequest : pb::IMessage<CorrespondenceRequest> {
    private static readonly pb::MessageParser<CorrespondenceRequest> _parser = new pb::MessageParser<CorrespondenceRequest>(() => new CorrespondenceRequest());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CorrespondenceRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.CRM.RPC.CorrespondenceSvcReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CorrespondenceRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CorrespondenceRequest(CorrespondenceRequest other) : this() {
      Reservation = other.reservation_ != null ? other.Reservation.Clone() : null;
      guests_ = other.guests_.Clone();
      contacts_ = other.contacts_.Clone();
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CorrespondenceRequest Clone() {
      return new CorrespondenceRequest(this);
    }

    /// <summary>Field number for the "reservation" field.</summary>
    public const int ReservationFieldNumber = 1;
    private global::HOLMS.Types.Booking.Indicators.ReservationIndicator reservation_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Booking.Indicators.ReservationIndicator Reservation {
      get { return reservation_; }
      set {
        reservation_ = value;
      }
    }

    /// <summary>Field number for the "guests" field.</summary>
    public const int GuestsFieldNumber = 2;
    private static readonly pb::FieldCodec<global::HOLMS.Types.CRM.Guests.GuestIndicator> _repeated_guests_codec
        = pb::FieldCodec.ForMessage(18, global::HOLMS.Types.CRM.Guests.GuestIndicator.Parser);
    private readonly pbc::RepeatedField<global::HOLMS.Types.CRM.Guests.GuestIndicator> guests_ = new pbc::RepeatedField<global::HOLMS.Types.CRM.Guests.GuestIndicator>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::HOLMS.Types.CRM.Guests.GuestIndicator> Guests {
      get { return guests_; }
    }

    /// <summary>Field number for the "contacts" field.</summary>
    public const int ContactsFieldNumber = 3;
    private static readonly pb::FieldCodec<global::HOLMS.Types.Booking.Reservations.ReservationContactPerson> _repeated_contacts_codec
        = pb::FieldCodec.ForMessage(26, global::HOLMS.Types.Booking.Reservations.ReservationContactPerson.Parser);
    private readonly pbc::RepeatedField<global::HOLMS.Types.Booking.Reservations.ReservationContactPerson> contacts_ = new pbc::RepeatedField<global::HOLMS.Types.Booking.Reservations.ReservationContactPerson>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::HOLMS.Types.Booking.Reservations.ReservationContactPerson> Contacts {
      get { return contacts_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CorrespondenceRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CorrespondenceRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Reservation, other.Reservation)) return false;
      if(!guests_.Equals(other.guests_)) return false;
      if(!contacts_.Equals(other.contacts_)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (reservation_ != null) hash ^= Reservation.GetHashCode();
      hash ^= guests_.GetHashCode();
      hash ^= contacts_.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (reservation_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Reservation);
      }
      guests_.WriteTo(output, _repeated_guests_codec);
      contacts_.WriteTo(output, _repeated_contacts_codec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (reservation_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Reservation);
      }
      size += guests_.CalculateSize(_repeated_guests_codec);
      size += contacts_.CalculateSize(_repeated_contacts_codec);
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CorrespondenceRequest other) {
      if (other == null) {
        return;
      }
      if (other.reservation_ != null) {
        if (reservation_ == null) {
          reservation_ = new global::HOLMS.Types.Booking.Indicators.ReservationIndicator();
        }
        Reservation.MergeFrom(other.Reservation);
      }
      guests_.Add(other.guests_);
      contacts_.Add(other.contacts_);
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
            if (reservation_ == null) {
              reservation_ = new global::HOLMS.Types.Booking.Indicators.ReservationIndicator();
            }
            input.ReadMessage(reservation_);
            break;
          }
          case 18: {
            guests_.AddEntriesFrom(input, _repeated_guests_codec);
            break;
          }
          case 26: {
            contacts_.AddEntriesFrom(input, _repeated_contacts_codec);
            break;
          }
        }
      }
    }

  }

  public sealed partial class CorrespondenceServiceDocumentResponse : pb::IMessage<CorrespondenceServiceDocumentResponse> {
    private static readonly pb::MessageParser<CorrespondenceServiceDocumentResponse> _parser = new pb::MessageParser<CorrespondenceServiceDocumentResponse>(() => new CorrespondenceServiceDocumentResponse());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CorrespondenceServiceDocumentResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.CRM.RPC.CorrespondenceSvcReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CorrespondenceServiceDocumentResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CorrespondenceServiceDocumentResponse(CorrespondenceServiceDocumentResponse other) : this() {
      document_ = other.document_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CorrespondenceServiceDocumentResponse Clone() {
      return new CorrespondenceServiceDocumentResponse(this);
    }

    /// <summary>Field number for the "document" field.</summary>
    public const int DocumentFieldNumber = 1;
    private string document_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Document {
      get { return document_; }
      set {
        document_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CorrespondenceServiceDocumentResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CorrespondenceServiceDocumentResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Document != other.Document) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Document.Length != 0) hash ^= Document.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Document.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Document);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Document.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Document);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CorrespondenceServiceDocumentResponse other) {
      if (other == null) {
        return;
      }
      if (other.Document.Length != 0) {
        Document = other.Document;
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
            Document = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
