// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: supply/room_types/room_type.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HOLMS.Types.Supply.RoomTypes {

  /// <summary>Holder for reflection information generated from supply/room_types/room_type.proto</summary>
  public static partial class RoomTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for supply/room_types/room_type.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RoomTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiFzdXBwbHkvcm9vbV90eXBlcy9yb29tX3R5cGUucHJvdG8SHWhvbG1zLnR5",
            "cGVzLnN1cHBseS5yb29tX3R5cGVzGitzdXBwbHkvcm9vbV90eXBlcy9yb29t",
            "X3R5cGVfaW5kaWNhdG9yLnByb3RvGjJ0ZW5hbmN5X2NvbmZpZy9pbmRpY2F0",
            "b3JzL3Byb3BlcnR5X2luZGljYXRvci5wcm90byLuAwoIUm9vbVR5cGUSQwoJ",
            "ZW50aXR5X2lkGAEgASgLMjAuaG9sbXMudHlwZXMuc3VwcGx5LnJvb21fdHlw",
            "ZXMuUm9vbVR5cGVJbmRpY2F0b3ISEwoLZGVzY3JpcHRpb24YAiABKAkSGAoQ",
            "bm9ybWFsX29jY3VwYW5jeRgEIAEoBRIVCg1tYXhfb2NjdXBhbmN5GAUgASgF",
            "EiMKG2NsZWFuaW5nX3RpbWVfY2hlY2tvdXRfbWlucxgGIAEoBRIjChtjbGVh",
            "bmluZ190aW1lX3N0YXlvdmVyX21pbnMYByABKAUSHwoXY2xlYW5pbmdfdGlt",
            "ZV9kdXN0X21pbnMYCCABKAUSHwoXY2xlYW5pbmdfdGltZV9kZWVwX21pbnMY",
            "CSABKAUSHQoVYmFzZV9tYW5hZ2VtZW50X2hvbGRzGAogASgFEhwKFGFkZGl0",
            "aW9uYWxfd2ViX2hvbGRzGAsgASgFEgwKBG5hbWUYDCABKAkSTQoLcHJvcGVy",
            "dHlfaWQYDSABKAsyOC5ob2xtcy50eXBlcy50ZW5hbmN5X2NvbmZpZy5pbmRp",
            "Y2F0b3JzLlByb3BlcnR5SW5kaWNhdG9yEhUKDXByb3BlcnR5X25hbWUYDiAB",
            "KAkSGgoSY2hhbm5lbF9tYW5hZ2VyX2lkGA8gASgJQjFaEHN1cHBseS9yb29t",
            "dHlwZXOqAhxIT0xNUy5UeXBlcy5TdXBwbHkuUm9vbVR5cGVzYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::HOLMS.Types.Supply.RoomTypes.RoomTypeIndicatorReflection.Descriptor, global::HOLMS.Types.TenancyConfig.Indicators.PropertyIndicatorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Supply.RoomTypes.RoomType), global::HOLMS.Types.Supply.RoomTypes.RoomType.Parser, new[]{ "EntityId", "Description", "NormalOccupancy", "MaxOccupancy", "CleaningTimeCheckoutMins", "CleaningTimeStayoverMins", "CleaningTimeDustMins", "CleaningTimeDeepMins", "BaseManagementHolds", "AdditionalWebHolds", "Name", "PropertyId", "PropertyName", "ChannelManagerId" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class RoomType : pb::IMessage<RoomType> {
    private static readonly pb::MessageParser<RoomType> _parser = new pb::MessageParser<RoomType>(() => new RoomType());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<RoomType> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Supply.RoomTypes.RoomTypeReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RoomType() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RoomType(RoomType other) : this() {
      EntityId = other.entityId_ != null ? other.EntityId.Clone() : null;
      description_ = other.description_;
      normalOccupancy_ = other.normalOccupancy_;
      maxOccupancy_ = other.maxOccupancy_;
      cleaningTimeCheckoutMins_ = other.cleaningTimeCheckoutMins_;
      cleaningTimeStayoverMins_ = other.cleaningTimeStayoverMins_;
      cleaningTimeDustMins_ = other.cleaningTimeDustMins_;
      cleaningTimeDeepMins_ = other.cleaningTimeDeepMins_;
      baseManagementHolds_ = other.baseManagementHolds_;
      additionalWebHolds_ = other.additionalWebHolds_;
      name_ = other.name_;
      PropertyId = other.propertyId_ != null ? other.PropertyId.Clone() : null;
      propertyName_ = other.propertyName_;
      channelManagerId_ = other.channelManagerId_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RoomType Clone() {
      return new RoomType(this);
    }

    /// <summary>Field number for the "entity_id" field.</summary>
    public const int EntityIdFieldNumber = 1;
    private global::HOLMS.Types.Supply.RoomTypes.RoomTypeIndicator entityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Supply.RoomTypes.RoomTypeIndicator EntityId {
      get { return entityId_; }
      set {
        entityId_ = value;
      }
    }

    /// <summary>Field number for the "description" field.</summary>
    public const int DescriptionFieldNumber = 2;
    private string description_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Description {
      get { return description_; }
      set {
        description_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "normal_occupancy" field.</summary>
    public const int NormalOccupancyFieldNumber = 4;
    private int normalOccupancy_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int NormalOccupancy {
      get { return normalOccupancy_; }
      set {
        normalOccupancy_ = value;
      }
    }

    /// <summary>Field number for the "max_occupancy" field.</summary>
    public const int MaxOccupancyFieldNumber = 5;
    private int maxOccupancy_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int MaxOccupancy {
      get { return maxOccupancy_; }
      set {
        maxOccupancy_ = value;
      }
    }

    /// <summary>Field number for the "cleaning_time_checkout_mins" field.</summary>
    public const int CleaningTimeCheckoutMinsFieldNumber = 6;
    private int cleaningTimeCheckoutMins_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CleaningTimeCheckoutMins {
      get { return cleaningTimeCheckoutMins_; }
      set {
        cleaningTimeCheckoutMins_ = value;
      }
    }

    /// <summary>Field number for the "cleaning_time_stayover_mins" field.</summary>
    public const int CleaningTimeStayoverMinsFieldNumber = 7;
    private int cleaningTimeStayoverMins_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CleaningTimeStayoverMins {
      get { return cleaningTimeStayoverMins_; }
      set {
        cleaningTimeStayoverMins_ = value;
      }
    }

    /// <summary>Field number for the "cleaning_time_dust_mins" field.</summary>
    public const int CleaningTimeDustMinsFieldNumber = 8;
    private int cleaningTimeDustMins_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CleaningTimeDustMins {
      get { return cleaningTimeDustMins_; }
      set {
        cleaningTimeDustMins_ = value;
      }
    }

    /// <summary>Field number for the "cleaning_time_deep_mins" field.</summary>
    public const int CleaningTimeDeepMinsFieldNumber = 9;
    private int cleaningTimeDeepMins_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CleaningTimeDeepMins {
      get { return cleaningTimeDeepMins_; }
      set {
        cleaningTimeDeepMins_ = value;
      }
    }

    /// <summary>Field number for the "base_management_holds" field.</summary>
    public const int BaseManagementHoldsFieldNumber = 10;
    private int baseManagementHolds_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int BaseManagementHolds {
      get { return baseManagementHolds_; }
      set {
        baseManagementHolds_ = value;
      }
    }

    /// <summary>Field number for the "additional_web_holds" field.</summary>
    public const int AdditionalWebHoldsFieldNumber = 11;
    private int additionalWebHolds_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int AdditionalWebHolds {
      get { return additionalWebHolds_; }
      set {
        additionalWebHolds_ = value;
      }
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 12;
    private string name_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "property_id" field.</summary>
    public const int PropertyIdFieldNumber = 13;
    private global::HOLMS.Types.TenancyConfig.Indicators.PropertyIndicator propertyId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.TenancyConfig.Indicators.PropertyIndicator PropertyId {
      get { return propertyId_; }
      set {
        propertyId_ = value;
      }
    }

    /// <summary>Field number for the "property_name" field.</summary>
    public const int PropertyNameFieldNumber = 14;
    private string propertyName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string PropertyName {
      get { return propertyName_; }
      set {
        propertyName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "channel_manager_id" field.</summary>
    public const int ChannelManagerIdFieldNumber = 15;
    private string channelManagerId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ChannelManagerId {
      get { return channelManagerId_; }
      set {
        channelManagerId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as RoomType);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(RoomType other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(EntityId, other.EntityId)) return false;
      if (Description != other.Description) return false;
      if (NormalOccupancy != other.NormalOccupancy) return false;
      if (MaxOccupancy != other.MaxOccupancy) return false;
      if (CleaningTimeCheckoutMins != other.CleaningTimeCheckoutMins) return false;
      if (CleaningTimeStayoverMins != other.CleaningTimeStayoverMins) return false;
      if (CleaningTimeDustMins != other.CleaningTimeDustMins) return false;
      if (CleaningTimeDeepMins != other.CleaningTimeDeepMins) return false;
      if (BaseManagementHolds != other.BaseManagementHolds) return false;
      if (AdditionalWebHolds != other.AdditionalWebHolds) return false;
      if (Name != other.Name) return false;
      if (!object.Equals(PropertyId, other.PropertyId)) return false;
      if (PropertyName != other.PropertyName) return false;
      if (ChannelManagerId != other.ChannelManagerId) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (entityId_ != null) hash ^= EntityId.GetHashCode();
      if (Description.Length != 0) hash ^= Description.GetHashCode();
      if (NormalOccupancy != 0) hash ^= NormalOccupancy.GetHashCode();
      if (MaxOccupancy != 0) hash ^= MaxOccupancy.GetHashCode();
      if (CleaningTimeCheckoutMins != 0) hash ^= CleaningTimeCheckoutMins.GetHashCode();
      if (CleaningTimeStayoverMins != 0) hash ^= CleaningTimeStayoverMins.GetHashCode();
      if (CleaningTimeDustMins != 0) hash ^= CleaningTimeDustMins.GetHashCode();
      if (CleaningTimeDeepMins != 0) hash ^= CleaningTimeDeepMins.GetHashCode();
      if (BaseManagementHolds != 0) hash ^= BaseManagementHolds.GetHashCode();
      if (AdditionalWebHolds != 0) hash ^= AdditionalWebHolds.GetHashCode();
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (propertyId_ != null) hash ^= PropertyId.GetHashCode();
      if (PropertyName.Length != 0) hash ^= PropertyName.GetHashCode();
      if (ChannelManagerId.Length != 0) hash ^= ChannelManagerId.GetHashCode();
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
      if (Description.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Description);
      }
      if (NormalOccupancy != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(NormalOccupancy);
      }
      if (MaxOccupancy != 0) {
        output.WriteRawTag(40);
        output.WriteInt32(MaxOccupancy);
      }
      if (CleaningTimeCheckoutMins != 0) {
        output.WriteRawTag(48);
        output.WriteInt32(CleaningTimeCheckoutMins);
      }
      if (CleaningTimeStayoverMins != 0) {
        output.WriteRawTag(56);
        output.WriteInt32(CleaningTimeStayoverMins);
      }
      if (CleaningTimeDustMins != 0) {
        output.WriteRawTag(64);
        output.WriteInt32(CleaningTimeDustMins);
      }
      if (CleaningTimeDeepMins != 0) {
        output.WriteRawTag(72);
        output.WriteInt32(CleaningTimeDeepMins);
      }
      if (BaseManagementHolds != 0) {
        output.WriteRawTag(80);
        output.WriteInt32(BaseManagementHolds);
      }
      if (AdditionalWebHolds != 0) {
        output.WriteRawTag(88);
        output.WriteInt32(AdditionalWebHolds);
      }
      if (Name.Length != 0) {
        output.WriteRawTag(98);
        output.WriteString(Name);
      }
      if (propertyId_ != null) {
        output.WriteRawTag(106);
        output.WriteMessage(PropertyId);
      }
      if (PropertyName.Length != 0) {
        output.WriteRawTag(114);
        output.WriteString(PropertyName);
      }
      if (ChannelManagerId.Length != 0) {
        output.WriteRawTag(122);
        output.WriteString(ChannelManagerId);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (entityId_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(EntityId);
      }
      if (Description.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Description);
      }
      if (NormalOccupancy != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(NormalOccupancy);
      }
      if (MaxOccupancy != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(MaxOccupancy);
      }
      if (CleaningTimeCheckoutMins != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(CleaningTimeCheckoutMins);
      }
      if (CleaningTimeStayoverMins != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(CleaningTimeStayoverMins);
      }
      if (CleaningTimeDustMins != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(CleaningTimeDustMins);
      }
      if (CleaningTimeDeepMins != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(CleaningTimeDeepMins);
      }
      if (BaseManagementHolds != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(BaseManagementHolds);
      }
      if (AdditionalWebHolds != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(AdditionalWebHolds);
      }
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (propertyId_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(PropertyId);
      }
      if (PropertyName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(PropertyName);
      }
      if (ChannelManagerId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ChannelManagerId);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(RoomType other) {
      if (other == null) {
        return;
      }
      if (other.entityId_ != null) {
        if (entityId_ == null) {
          entityId_ = new global::HOLMS.Types.Supply.RoomTypes.RoomTypeIndicator();
        }
        EntityId.MergeFrom(other.EntityId);
      }
      if (other.Description.Length != 0) {
        Description = other.Description;
      }
      if (other.NormalOccupancy != 0) {
        NormalOccupancy = other.NormalOccupancy;
      }
      if (other.MaxOccupancy != 0) {
        MaxOccupancy = other.MaxOccupancy;
      }
      if (other.CleaningTimeCheckoutMins != 0) {
        CleaningTimeCheckoutMins = other.CleaningTimeCheckoutMins;
      }
      if (other.CleaningTimeStayoverMins != 0) {
        CleaningTimeStayoverMins = other.CleaningTimeStayoverMins;
      }
      if (other.CleaningTimeDustMins != 0) {
        CleaningTimeDustMins = other.CleaningTimeDustMins;
      }
      if (other.CleaningTimeDeepMins != 0) {
        CleaningTimeDeepMins = other.CleaningTimeDeepMins;
      }
      if (other.BaseManagementHolds != 0) {
        BaseManagementHolds = other.BaseManagementHolds;
      }
      if (other.AdditionalWebHolds != 0) {
        AdditionalWebHolds = other.AdditionalWebHolds;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.propertyId_ != null) {
        if (propertyId_ == null) {
          propertyId_ = new global::HOLMS.Types.TenancyConfig.Indicators.PropertyIndicator();
        }
        PropertyId.MergeFrom(other.PropertyId);
      }
      if (other.PropertyName.Length != 0) {
        PropertyName = other.PropertyName;
      }
      if (other.ChannelManagerId.Length != 0) {
        ChannelManagerId = other.ChannelManagerId;
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
              entityId_ = new global::HOLMS.Types.Supply.RoomTypes.RoomTypeIndicator();
            }
            input.ReadMessage(entityId_);
            break;
          }
          case 18: {
            Description = input.ReadString();
            break;
          }
          case 32: {
            NormalOccupancy = input.ReadInt32();
            break;
          }
          case 40: {
            MaxOccupancy = input.ReadInt32();
            break;
          }
          case 48: {
            CleaningTimeCheckoutMins = input.ReadInt32();
            break;
          }
          case 56: {
            CleaningTimeStayoverMins = input.ReadInt32();
            break;
          }
          case 64: {
            CleaningTimeDustMins = input.ReadInt32();
            break;
          }
          case 72: {
            CleaningTimeDeepMins = input.ReadInt32();
            break;
          }
          case 80: {
            BaseManagementHolds = input.ReadInt32();
            break;
          }
          case 88: {
            AdditionalWebHolds = input.ReadInt32();
            break;
          }
          case 98: {
            Name = input.ReadString();
            break;
          }
          case 106: {
            if (propertyId_ == null) {
              propertyId_ = new global::HOLMS.Types.TenancyConfig.Indicators.PropertyIndicator();
            }
            input.ReadMessage(propertyId_);
            break;
          }
          case 114: {
            PropertyName = input.ReadString();
            break;
          }
          case 122: {
            ChannelManagerId = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
