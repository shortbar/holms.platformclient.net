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
            "dF9pbmRpY2F0b3IucHJvdG8aHXByaW1pdGl2ZS9wYl9sb2NhbF9kYXRlLnBy",
            "b3RvGjF0ZW5hbmN5X2NvbmZpZy9wcm9wZXJ0eV9hcnJpdmFsX2xldHRlcl90",
            "ZXh0LnByb3RvGjZ0ZW5hbmN5X2NvbmZpZy9wcm9wZXJ0eV9jYW5jZWxsYXRp",
            "b25fbGV0dGVyX3RleHQucHJvdG8aNnRlbmFuY3lfY29uZmlnL3Byb3BlcnR5",
            "X2NvbmZpcm1hdGlvbl9sZXR0ZXJfdGV4dC5wcm90byLoAQoVQ29ycmVzcG9u",
            "ZGVuY2VSZXF1ZXN0EkkKC3Jlc2VydmF0aW9uGAEgASgLMjQuaG9sbXMudHlw",
            "ZXMuYm9va2luZy5pbmRpY2F0b3JzLlJlc2VydmF0aW9uSW5kaWNhdG9yEjYK",
            "Bmd1ZXN0cxgCIAMoCzImLmhvbG1zLnR5cGVzLmNybS5ndWVzdHMuR3Vlc3RJ",
            "bmRpY2F0b3ISTAoIY29udGFjdHMYAyADKAsyOi5ob2xtcy50eXBlcy5ib29r",
            "aW5nLnJlc2VydmF0aW9ucy5SZXNlcnZhdGlvbkNvbnRhY3RQZXJzb24iOQol",
            "Q29ycmVzcG9uZGVuY2VTZXJ2aWNlRG9jdW1lbnRSZXNwb25zZRIQCghkb2N1",
            "bWVudBgBIAEoCSKXAQokQ29ycmVzcG9uZGVuY2VTZXJ2aWNlRW1haWxTZW5k",
            "UmVzdWx0Ek4KC3NlbmRfc3RhdHVzGAEgASgOMjkuaG9sbXMudHlwZXMuY3Jt",
            "LnJwYy5Db3JyZXNwb25kZW5jZVNlcnZpY2VFbWFpbFNlbmRTdGF0dXMSHwoX",
            "cmVjaXBpZW50X2VtYWlsX2FkZHJlc3MYAiABKAkidAomQ29ycmVzcG9uZGVu",
            "Y2VTZXJ2aWNlRW1haWxTZW5kUmVzcG9uc2USSgoHcmVzdWx0cxgBIAMoCzI5",
            "LmhvbG1zLnR5cGVzLmNybS5ycGMuQ29ycmVzcG9uZGVuY2VTZXJ2aWNlRW1h",
            "aWxTZW5kUmVzdWx0KrsBCiRDb3JyZXNwb25kZW5jZVNlcnZpY2VFbWFpbFNl",
            "bmRTdGF0dXMSHQoZRU1BSUxfU0VORF9TVEFUVVNfU1VDQ0VTUxAAEiQKIEVN",
            "QUlMX1NFTkRfU1RBVFVTX1NFUlZFUl9GQUlMVVJFEAESJQohRU1BSUxfU0VO",
            "RF9TVEFUVVNfVU5LTk9XTl9GQUlMVVJFEAISJwojRU1BSUxfU0VORF9TVEFU",
            "VVNfSU5WQUxJRF9SRUNJUElFTlQQAzK7DQoRQ29ycmVzcG9uZGVuY2VTdmMS",
            "gQEKFlNlbmRDb25maXJtYXRpb25MZXR0ZXISKi5ob2xtcy50eXBlcy5jcm0u",
            "cnBjLkNvcnJlc3BvbmRlbmNlUmVxdWVzdBo7LmhvbG1zLnR5cGVzLmNybS5y",
            "cGMuQ29ycmVzcG9uZGVuY2VTZXJ2aWNlRW1haWxTZW5kUmVzcG9uc2USgAEK",
            "FVNlbmRDYW5jZWxsYXRpb25FbWFpbBIqLmhvbG1zLnR5cGVzLmNybS5ycGMu",
            "Q29ycmVzcG9uZGVuY2VSZXF1ZXN0GjsuaG9sbXMudHlwZXMuY3JtLnJwYy5D",
            "b3JyZXNwb25kZW5jZVNlcnZpY2VFbWFpbFNlbmRSZXNwb25zZRJ5Cg5TZW5k",
            "R3Vlc3RGb2xpbxIqLmhvbG1zLnR5cGVzLmNybS5ycGMuQ29ycmVzcG9uZGVu",
            "Y2VSZXF1ZXN0GjsuaG9sbXMudHlwZXMuY3JtLnJwYy5Db3JyZXNwb25kZW5j",
            "ZVNlcnZpY2VFbWFpbFNlbmRSZXNwb25zZRKJAQoUUHJldmlld0Fycml2YWxM",
            "ZXR0ZXISNS5ob2xtcy50eXBlcy50ZW5hbmN5X2NvbmZpZy5Qcm9wZXJ0eUFy",
            "cml2YWxMZXR0ZXJUZXh0GjouaG9sbXMudHlwZXMuY3JtLnJwYy5Db3JyZXNw",
            "b25kZW5jZVNlcnZpY2VEb2N1bWVudFJlc3BvbnNlEoUBCiNHZXRBcnJpdmFs",
            "TGV0dGVyRG9jdW1lbnRzQXJyaXZpbmdPbhIiLmhvbG1zLnR5cGVzLnByaW1p",
            "dGl2ZS5QYkxvY2FsRGF0ZRo6LmhvbG1zLnR5cGVzLmNybS5ycGMuQ29ycmVz",
            "cG9uZGVuY2VTZXJ2aWNlRG9jdW1lbnRSZXNwb25zZRKMAQoYR2V0QXJyaXZh",
            "bExldHRlckRvY3VtZW50EjQuaG9sbXMudHlwZXMuYm9va2luZy5pbmRpY2F0",
            "b3JzLlJlc2VydmF0aW9uSW5kaWNhdG9yGjouaG9sbXMudHlwZXMuY3JtLnJw",
            "Yy5Db3JyZXNwb25kZW5jZVNlcnZpY2VEb2N1bWVudFJlc3BvbnNlEpYBCiFH",
            "ZXRCb29raW5nQXNzb2NpYXRlZEZvbGlvc1N1bW1hcnkSNS5ob2xtcy50eXBl",
            "cy5ib29raW5nLmluZGljYXRvcnMuR3JvdXBCb29raW5nSW5kaWNhdG9yGjou",
            "aG9sbXMudHlwZXMuY3JtLnJwYy5Db3JyZXNwb25kZW5jZVNlcnZpY2VEb2N1",
            "bWVudFJlc3BvbnNlEpMBChlQcmV2aWV3Q29uZmlybWF0aW9uTGV0dGVyEjou",
            "aG9sbXMudHlwZXMudGVuYW5jeV9jb25maWcuUHJvcGVydHlDb25maXJtYXRp",
            "b25MZXR0ZXJUZXh0GjouaG9sbXMudHlwZXMuY3JtLnJwYy5Db3JyZXNwb25k",
            "ZW5jZVNlcnZpY2VEb2N1bWVudFJlc3BvbnNlEpIBChhQcmV2aWV3Q2FuY2Vs",
            "bGF0aW9uRW1haWwSOi5ob2xtcy50eXBlcy50ZW5hbmN5X2NvbmZpZy5Qcm9w",
            "ZXJ0eUNhbmNlbGxhdGlvbkxldHRlclRleHQaOi5ob2xtcy50eXBlcy5jcm0u",
            "cnBjLkNvcnJlc3BvbmRlbmNlU2VydmljZURvY3VtZW50UmVzcG9uc2USjwEK",
            "G0dldFJlc2VydmF0aW9uRm9saW9QcmludERvYxI0LmhvbG1zLnR5cGVzLmJv",
            "b2tpbmcuaW5kaWNhdG9ycy5SZXNlcnZhdGlvbkluZGljYXRvcho6LmhvbG1z",
            "LnR5cGVzLmNybS5ycGMuQ29ycmVzcG9uZGVuY2VTZXJ2aWNlRG9jdW1lbnRS",
            "ZXNwb25zZRKRAQocR2V0R3JvdXBCb29raW5nRm9saW9QcmludERvYxI1Lmhv",
            "bG1zLnR5cGVzLmJvb2tpbmcuaW5kaWNhdG9ycy5Hcm91cEJvb2tpbmdJbmRp",
            "Y2F0b3IaOi5ob2xtcy50eXBlcy5jcm0ucnBjLkNvcnJlc3BvbmRlbmNlU2Vy",
            "dmljZURvY3VtZW50UmVzcG9uc2USlgEKIkdldFJlc2VydmF0aW9uQ29uZmly",
            "bWF0aW9uUHJpbnREb2MSNC5ob2xtcy50eXBlcy5ib29raW5nLmluZGljYXRv",
            "cnMuUmVzZXJ2YXRpb25JbmRpY2F0b3IaOi5ob2xtcy50eXBlcy5jcm0ucnBj",
            "LkNvcnJlc3BvbmRlbmNlU2VydmljZURvY3VtZW50UmVzcG9uc2VCFqoCE0hP",
            "TE1TLlR5cGVzLkNSTS5SUENiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::HOLMS.Types.Booking.Indicators.GroupBookingIndicatorReflection.Descriptor, global::HOLMS.Types.Booking.Indicators.ReservationIndicatorReflection.Descriptor, global::HOLMS.Types.Booking.Reservations.ReservationContactPersonReflection.Descriptor, global::HOLMS.Types.CRM.Guests.GuestIndicatorReflection.Descriptor, global::HOLMS.Types.Primitive.PbLocalDateReflection.Descriptor, global::HOLMS.Types.TenancyConfig.PropertyArrivalLetterTextReflection.Descriptor, global::HOLMS.Types.TenancyConfig.PropertyCancellationLetterTextReflection.Descriptor, global::HOLMS.Types.TenancyConfig.PropertyConfirmationLetterTextReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::HOLMS.Types.CRM.RPC.CorrespondenceServiceEmailSendStatus), }, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.CRM.RPC.CorrespondenceRequest), global::HOLMS.Types.CRM.RPC.CorrespondenceRequest.Parser, new[]{ "Reservation", "Guests", "Contacts" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.CRM.RPC.CorrespondenceServiceDocumentResponse), global::HOLMS.Types.CRM.RPC.CorrespondenceServiceDocumentResponse.Parser, new[]{ "Document" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.CRM.RPC.CorrespondenceServiceEmailSendResult), global::HOLMS.Types.CRM.RPC.CorrespondenceServiceEmailSendResult.Parser, new[]{ "SendStatus", "RecipientEmailAddress" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.CRM.RPC.CorrespondenceServiceEmailSendResponse), global::HOLMS.Types.CRM.RPC.CorrespondenceServiceEmailSendResponse.Parser, new[]{ "Results" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Enums
  public enum CorrespondenceServiceEmailSendStatus {
    [pbr::OriginalName("EMAIL_SEND_STATUS_SUCCESS")] EmailSendStatusSuccess = 0,
    [pbr::OriginalName("EMAIL_SEND_STATUS_SERVER_FAILURE")] EmailSendStatusServerFailure = 1,
    [pbr::OriginalName("EMAIL_SEND_STATUS_UNKNOWN_FAILURE")] EmailSendStatusUnknownFailure = 2,
    [pbr::OriginalName("EMAIL_SEND_STATUS_INVALID_RECIPIENT")] EmailSendStatusInvalidRecipient = 3,
  }

  #endregion

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

  public sealed partial class CorrespondenceServiceEmailSendResult : pb::IMessage<CorrespondenceServiceEmailSendResult> {
    private static readonly pb::MessageParser<CorrespondenceServiceEmailSendResult> _parser = new pb::MessageParser<CorrespondenceServiceEmailSendResult>(() => new CorrespondenceServiceEmailSendResult());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CorrespondenceServiceEmailSendResult> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.CRM.RPC.CorrespondenceSvcReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CorrespondenceServiceEmailSendResult() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CorrespondenceServiceEmailSendResult(CorrespondenceServiceEmailSendResult other) : this() {
      sendStatus_ = other.sendStatus_;
      recipientEmailAddress_ = other.recipientEmailAddress_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CorrespondenceServiceEmailSendResult Clone() {
      return new CorrespondenceServiceEmailSendResult(this);
    }

    /// <summary>Field number for the "send_status" field.</summary>
    public const int SendStatusFieldNumber = 1;
    private global::HOLMS.Types.CRM.RPC.CorrespondenceServiceEmailSendStatus sendStatus_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.CRM.RPC.CorrespondenceServiceEmailSendStatus SendStatus {
      get { return sendStatus_; }
      set {
        sendStatus_ = value;
      }
    }

    /// <summary>Field number for the "recipient_email_address" field.</summary>
    public const int RecipientEmailAddressFieldNumber = 2;
    private string recipientEmailAddress_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string RecipientEmailAddress {
      get { return recipientEmailAddress_; }
      set {
        recipientEmailAddress_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CorrespondenceServiceEmailSendResult);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CorrespondenceServiceEmailSendResult other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (SendStatus != other.SendStatus) return false;
      if (RecipientEmailAddress != other.RecipientEmailAddress) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (SendStatus != 0) hash ^= SendStatus.GetHashCode();
      if (RecipientEmailAddress.Length != 0) hash ^= RecipientEmailAddress.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (SendStatus != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) SendStatus);
      }
      if (RecipientEmailAddress.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(RecipientEmailAddress);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (SendStatus != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) SendStatus);
      }
      if (RecipientEmailAddress.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(RecipientEmailAddress);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CorrespondenceServiceEmailSendResult other) {
      if (other == null) {
        return;
      }
      if (other.SendStatus != 0) {
        SendStatus = other.SendStatus;
      }
      if (other.RecipientEmailAddress.Length != 0) {
        RecipientEmailAddress = other.RecipientEmailAddress;
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
            sendStatus_ = (global::HOLMS.Types.CRM.RPC.CorrespondenceServiceEmailSendStatus) input.ReadEnum();
            break;
          }
          case 18: {
            RecipientEmailAddress = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class CorrespondenceServiceEmailSendResponse : pb::IMessage<CorrespondenceServiceEmailSendResponse> {
    private static readonly pb::MessageParser<CorrespondenceServiceEmailSendResponse> _parser = new pb::MessageParser<CorrespondenceServiceEmailSendResponse>(() => new CorrespondenceServiceEmailSendResponse());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CorrespondenceServiceEmailSendResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.CRM.RPC.CorrespondenceSvcReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CorrespondenceServiceEmailSendResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CorrespondenceServiceEmailSendResponse(CorrespondenceServiceEmailSendResponse other) : this() {
      results_ = other.results_.Clone();
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CorrespondenceServiceEmailSendResponse Clone() {
      return new CorrespondenceServiceEmailSendResponse(this);
    }

    /// <summary>Field number for the "results" field.</summary>
    public const int ResultsFieldNumber = 1;
    private static readonly pb::FieldCodec<global::HOLMS.Types.CRM.RPC.CorrespondenceServiceEmailSendResult> _repeated_results_codec
        = pb::FieldCodec.ForMessage(10, global::HOLMS.Types.CRM.RPC.CorrespondenceServiceEmailSendResult.Parser);
    private readonly pbc::RepeatedField<global::HOLMS.Types.CRM.RPC.CorrespondenceServiceEmailSendResult> results_ = new pbc::RepeatedField<global::HOLMS.Types.CRM.RPC.CorrespondenceServiceEmailSendResult>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::HOLMS.Types.CRM.RPC.CorrespondenceServiceEmailSendResult> Results {
      get { return results_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CorrespondenceServiceEmailSendResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CorrespondenceServiceEmailSendResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!results_.Equals(other.results_)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= results_.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      results_.WriteTo(output, _repeated_results_codec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += results_.CalculateSize(_repeated_results_codec);
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CorrespondenceServiceEmailSendResponse other) {
      if (other == null) {
        return;
      }
      results_.Add(other.results_);
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
            results_.AddEntriesFrom(input, _repeated_results_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
