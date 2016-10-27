// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: supply/incidental_items/item_hold_creation_request.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HOLMS.Types.Supply.IncidentalItems {

  /// <summary>Holder for reflection information generated from supply/incidental_items/item_hold_creation_request.proto</summary>
  public static partial class ItemHoldCreationRequestReflection {

    #region Descriptor
    /// <summary>File descriptor for supply/incidental_items/item_hold_creation_request.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ItemHoldCreationRequestReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjhzdXBwbHkvaW5jaWRlbnRhbF9pdGVtcy9pdGVtX2hvbGRfY3JlYXRpb25f",
            "cmVxdWVzdC5wcm90bxIjaG9sbXMudHlwZXMuc3VwcGx5LmluY2lkZW50YWxf",
            "aXRlbXMaKnByaW1pdGl2ZS9wYl9pbmNsdXNpdmVfb3BzZGF0ZV9yYW5nZS5w",
            "cm90bxouYm9va2luZy9pbmRpY2F0b3JzL3Jlc2VydmF0aW9uX2luZGljYXRv",
            "ci5wcm90bxo3c3VwcGx5L2luY2lkZW50YWxfaXRlbXMvaW5jaWRlbnRhbF9p",
            "dGVtX2luZGljYXRvci5wcm90byKjAgoXSXRlbUhvbGRDcmVhdGlvblJlcXVl",
            "c3QSSgoEaXRlbRgBIAEoCzI8LmhvbG1zLnR5cGVzLnN1cHBseS5pbmNpZGVu",
            "dGFsX2l0ZW1zLkluY2lkZW50YWxJdGVtSW5kaWNhdG9yEkIKCmRhdGVfcmFu",
            "Z2UYAiABKAsyLi5ob2xtcy50eXBlcy5wcmltaXRpdmUuUGJJbmNsdXNpdmVP",
            "cHNkYXRlUmFuZ2USXAoeYXNzb2NpYXRlZF9sb2RnaW5nX3Jlc2VydmF0aW9u",
            "GAMgASgLMjQuaG9sbXMudHlwZXMuYm9va2luZy5pbmRpY2F0b3JzLlJlc2Vy",
            "dmF0aW9uSW5kaWNhdG9yEhoKEnJlcXVlc3RlZF9xdWFudGl0eRgEIAEoDUI9",
            "WhZzdXBwbHkvaW5jaWRlbnRhbGl0ZW1zqgIiSE9MTVMuVHlwZXMuU3VwcGx5",
            "LkluY2lkZW50YWxJdGVtc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::HOLMS.Types.Primitive.PbInclusiveOpsdateRangeReflection.Descriptor, global::HOLMS.Types.Booking.Indicators.ReservationIndicatorReflection.Descriptor, global::HOLMS.Types.Supply.IncidentalItems.IncidentalItemIndicatorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Supply.IncidentalItems.ItemHoldCreationRequest), global::HOLMS.Types.Supply.IncidentalItems.ItemHoldCreationRequest.Parser, new[]{ "Item", "DateRange", "AssociatedLodgingReservation", "RequestedQuantity" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ItemHoldCreationRequest : pb::IMessage<ItemHoldCreationRequest> {
    private static readonly pb::MessageParser<ItemHoldCreationRequest> _parser = new pb::MessageParser<ItemHoldCreationRequest>(() => new ItemHoldCreationRequest());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ItemHoldCreationRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Supply.IncidentalItems.ItemHoldCreationRequestReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ItemHoldCreationRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ItemHoldCreationRequest(ItemHoldCreationRequest other) : this() {
      Item = other.item_ != null ? other.Item.Clone() : null;
      DateRange = other.dateRange_ != null ? other.DateRange.Clone() : null;
      AssociatedLodgingReservation = other.associatedLodgingReservation_ != null ? other.AssociatedLodgingReservation.Clone() : null;
      requestedQuantity_ = other.requestedQuantity_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ItemHoldCreationRequest Clone() {
      return new ItemHoldCreationRequest(this);
    }

    /// <summary>Field number for the "item" field.</summary>
    public const int ItemFieldNumber = 1;
    private global::HOLMS.Types.Supply.IncidentalItems.IncidentalItemIndicator item_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Supply.IncidentalItems.IncidentalItemIndicator Item {
      get { return item_; }
      set {
        item_ = value;
      }
    }

    /// <summary>Field number for the "date_range" field.</summary>
    public const int DateRangeFieldNumber = 2;
    private global::HOLMS.Types.Primitive.PbInclusiveOpsdateRange dateRange_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Primitive.PbInclusiveOpsdateRange DateRange {
      get { return dateRange_; }
      set {
        dateRange_ = value;
      }
    }

    /// <summary>Field number for the "associated_lodging_reservation" field.</summary>
    public const int AssociatedLodgingReservationFieldNumber = 3;
    private global::HOLMS.Types.Booking.Indicators.ReservationIndicator associatedLodgingReservation_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Booking.Indicators.ReservationIndicator AssociatedLodgingReservation {
      get { return associatedLodgingReservation_; }
      set {
        associatedLodgingReservation_ = value;
      }
    }

    /// <summary>Field number for the "requested_quantity" field.</summary>
    public const int RequestedQuantityFieldNumber = 4;
    private uint requestedQuantity_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint RequestedQuantity {
      get { return requestedQuantity_; }
      set {
        requestedQuantity_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ItemHoldCreationRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ItemHoldCreationRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Item, other.Item)) return false;
      if (!object.Equals(DateRange, other.DateRange)) return false;
      if (!object.Equals(AssociatedLodgingReservation, other.AssociatedLodgingReservation)) return false;
      if (RequestedQuantity != other.RequestedQuantity) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (item_ != null) hash ^= Item.GetHashCode();
      if (dateRange_ != null) hash ^= DateRange.GetHashCode();
      if (associatedLodgingReservation_ != null) hash ^= AssociatedLodgingReservation.GetHashCode();
      if (RequestedQuantity != 0) hash ^= RequestedQuantity.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (item_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Item);
      }
      if (dateRange_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(DateRange);
      }
      if (associatedLodgingReservation_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(AssociatedLodgingReservation);
      }
      if (RequestedQuantity != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(RequestedQuantity);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (item_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Item);
      }
      if (dateRange_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(DateRange);
      }
      if (associatedLodgingReservation_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(AssociatedLodgingReservation);
      }
      if (RequestedQuantity != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(RequestedQuantity);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ItemHoldCreationRequest other) {
      if (other == null) {
        return;
      }
      if (other.item_ != null) {
        if (item_ == null) {
          item_ = new global::HOLMS.Types.Supply.IncidentalItems.IncidentalItemIndicator();
        }
        Item.MergeFrom(other.Item);
      }
      if (other.dateRange_ != null) {
        if (dateRange_ == null) {
          dateRange_ = new global::HOLMS.Types.Primitive.PbInclusiveOpsdateRange();
        }
        DateRange.MergeFrom(other.DateRange);
      }
      if (other.associatedLodgingReservation_ != null) {
        if (associatedLodgingReservation_ == null) {
          associatedLodgingReservation_ = new global::HOLMS.Types.Booking.Indicators.ReservationIndicator();
        }
        AssociatedLodgingReservation.MergeFrom(other.AssociatedLodgingReservation);
      }
      if (other.RequestedQuantity != 0) {
        RequestedQuantity = other.RequestedQuantity;
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
            if (item_ == null) {
              item_ = new global::HOLMS.Types.Supply.IncidentalItems.IncidentalItemIndicator();
            }
            input.ReadMessage(item_);
            break;
          }
          case 18: {
            if (dateRange_ == null) {
              dateRange_ = new global::HOLMS.Types.Primitive.PbInclusiveOpsdateRange();
            }
            input.ReadMessage(dateRange_);
            break;
          }
          case 26: {
            if (associatedLodgingReservation_ == null) {
              associatedLodgingReservation_ = new global::HOLMS.Types.Booking.Indicators.ReservationIndicator();
            }
            input.ReadMessage(associatedLodgingReservation_);
            break;
          }
          case 32: {
            RequestedQuantity = input.ReadUInt32();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
