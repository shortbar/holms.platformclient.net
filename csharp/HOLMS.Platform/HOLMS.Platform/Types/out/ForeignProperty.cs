// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: tenancy_config/foreign_property.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HOLMS.Types.TenancyConfig {

  /// <summary>Holder for reflection information generated from tenancy_config/foreign_property.proto</summary>
  public static partial class ForeignPropertyReflection {

    #region Descriptor
    /// <summary>File descriptor for tenancy_config/foreign_property.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ForeignPropertyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiV0ZW5hbmN5X2NvbmZpZy9mb3JlaWduX3Byb3BlcnR5LnByb3RvEhpob2xt",
            "cy50eXBlcy50ZW5hbmN5X2NvbmZpZxoUcHJpbWl0aXZlL3V1aWQucHJvdG8a",
            "OnRlbmFuY3lfY29uZmlnL2luZGljYXRvcnMvZm9yZWlnbl9wcm9wZXJ0eV9p",
            "bmRpY2F0b3IucHJvdG8iwwEKD0ZvcmVpZ25Qcm9wZXJ0eRIVCg1wcm9wZXJ0",
            "eV9uYW1lGAEgASgJEjAKC3Byb3BlcnR5X2lkGAIgASgLMhsuaG9sbXMudHlw",
            "ZXMucHJpbWl0aXZlLlV1aWQSEwoLYm9va2luZ191cmwYAyABKAkSUgoJZW50",
            "aXR5X2lkGAQgASgLMj8uaG9sbXMudHlwZXMudGVuYW5jeV9jb25maWcuaW5k",
            "aWNhdG9ycy5Gb3JlaWduUHJvcGVydHlJbmRpY2F0b3JCHKoCGUhPTE1TLlR5",
            "cGVzLlRlbmFuY3lDb25maWdiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::HOLMS.Types.Primitive.UuidReflection.Descriptor, global::HOLMS.Types.TenancyConfig.Indicators.ForeignPropertyIndicatorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.TenancyConfig.ForeignProperty), global::HOLMS.Types.TenancyConfig.ForeignProperty.Parser, new[]{ "PropertyName", "PropertyId", "BookingUrl", "EntityId" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ForeignProperty : pb::IMessage<ForeignProperty> {
    private static readonly pb::MessageParser<ForeignProperty> _parser = new pb::MessageParser<ForeignProperty>(() => new ForeignProperty());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ForeignProperty> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.TenancyConfig.ForeignPropertyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ForeignProperty() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ForeignProperty(ForeignProperty other) : this() {
      propertyName_ = other.propertyName_;
      PropertyId = other.propertyId_ != null ? other.PropertyId.Clone() : null;
      bookingUrl_ = other.bookingUrl_;
      EntityId = other.entityId_ != null ? other.EntityId.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ForeignProperty Clone() {
      return new ForeignProperty(this);
    }

    /// <summary>Field number for the "property_name" field.</summary>
    public const int PropertyNameFieldNumber = 1;
    private string propertyName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string PropertyName {
      get { return propertyName_; }
      set {
        propertyName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "property_id" field.</summary>
    public const int PropertyIdFieldNumber = 2;
    private global::HOLMS.Types.Primitive.Uuid propertyId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Primitive.Uuid PropertyId {
      get { return propertyId_; }
      set {
        propertyId_ = value;
      }
    }

    /// <summary>Field number for the "booking_url" field.</summary>
    public const int BookingUrlFieldNumber = 3;
    private string bookingUrl_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string BookingUrl {
      get { return bookingUrl_; }
      set {
        bookingUrl_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "entity_id" field.</summary>
    public const int EntityIdFieldNumber = 4;
    private global::HOLMS.Types.TenancyConfig.Indicators.ForeignPropertyIndicator entityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.TenancyConfig.Indicators.ForeignPropertyIndicator EntityId {
      get { return entityId_; }
      set {
        entityId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ForeignProperty);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ForeignProperty other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (PropertyName != other.PropertyName) return false;
      if (!object.Equals(PropertyId, other.PropertyId)) return false;
      if (BookingUrl != other.BookingUrl) return false;
      if (!object.Equals(EntityId, other.EntityId)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (PropertyName.Length != 0) hash ^= PropertyName.GetHashCode();
      if (propertyId_ != null) hash ^= PropertyId.GetHashCode();
      if (BookingUrl.Length != 0) hash ^= BookingUrl.GetHashCode();
      if (entityId_ != null) hash ^= EntityId.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (PropertyName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(PropertyName);
      }
      if (propertyId_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(PropertyId);
      }
      if (BookingUrl.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(BookingUrl);
      }
      if (entityId_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(EntityId);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (PropertyName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(PropertyName);
      }
      if (propertyId_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(PropertyId);
      }
      if (BookingUrl.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(BookingUrl);
      }
      if (entityId_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(EntityId);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ForeignProperty other) {
      if (other == null) {
        return;
      }
      if (other.PropertyName.Length != 0) {
        PropertyName = other.PropertyName;
      }
      if (other.propertyId_ != null) {
        if (propertyId_ == null) {
          propertyId_ = new global::HOLMS.Types.Primitive.Uuid();
        }
        PropertyId.MergeFrom(other.PropertyId);
      }
      if (other.BookingUrl.Length != 0) {
        BookingUrl = other.BookingUrl;
      }
      if (other.entityId_ != null) {
        if (entityId_ == null) {
          entityId_ = new global::HOLMS.Types.TenancyConfig.Indicators.ForeignPropertyIndicator();
        }
        EntityId.MergeFrom(other.EntityId);
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
            PropertyName = input.ReadString();
            break;
          }
          case 18: {
            if (propertyId_ == null) {
              propertyId_ = new global::HOLMS.Types.Primitive.Uuid();
            }
            input.ReadMessage(propertyId_);
            break;
          }
          case 26: {
            BookingUrl = input.ReadString();
            break;
          }
          case 34: {
            if (entityId_ == null) {
              entityId_ = new global::HOLMS.Types.TenancyConfig.Indicators.ForeignPropertyIndicator();
            }
            input.ReadMessage(entityId_);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
