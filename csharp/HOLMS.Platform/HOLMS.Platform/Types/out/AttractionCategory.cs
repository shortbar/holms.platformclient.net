// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: operations/attractions/attraction_category.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HOLMS.Types.Operations.Attractions {

  /// <summary>Holder for reflection information generated from operations/attractions/attraction_category.proto</summary>
  public static partial class AttractionCategoryReflection {

    #region Descriptor
    /// <summary>File descriptor for operations/attractions/attraction_category.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AttractionCategoryReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjBvcGVyYXRpb25zL2F0dHJhY3Rpb25zL2F0dHJhY3Rpb25fY2F0ZWdvcnku",
            "cHJvdG8SImhvbG1zLnR5cGVzLm9wZXJhdGlvbnMuYXR0cmFjdGlvbnMaJ29w",
            "ZXJhdGlvbnMvYXR0cmFjdGlvbnMvYXR0cmFjdGlvbi5wcm90bxo6b3BlcmF0",
            "aW9ucy9hdHRyYWN0aW9ucy9hdHRyYWN0aW9uX2NhdGVnb3J5X2luZGljYXRv",
            "ci5wcm90byK7AQoSQXR0cmFjdGlvbkNhdGVnb3J5ElIKCWVudGl0eV9pZBgB",
            "IAEoCzI/LmhvbG1zLnR5cGVzLm9wZXJhdGlvbnMuYXR0cmFjdGlvbnMuQXR0",
            "cmFjdGlvbkNhdGVnb3J5SW5kaWNhdG9yEgwKBG5hbWUYAiABKAkSQwoLYXR0",
            "cmFjdGlvbnMYAyADKAsyLi5ob2xtcy50eXBlcy5vcGVyYXRpb25zLmF0dHJh",
            "Y3Rpb25zLkF0dHJhY3Rpb25CPVoWb3BlcmF0aW9ucy9hdHRyYWN0aW9uc6oC",
            "IkhPTE1TLlR5cGVzLk9wZXJhdGlvbnMuQXR0cmFjdGlvbnNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::HOLMS.Types.Operations.Attractions.AttractionReflection.Descriptor, global::HOLMS.Types.Operations.Attractions.AttractionCategoryIndicatorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Operations.Attractions.AttractionCategory), global::HOLMS.Types.Operations.Attractions.AttractionCategory.Parser, new[]{ "EntityId", "Name", "Attractions" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class AttractionCategory : pb::IMessage<AttractionCategory> {
    private static readonly pb::MessageParser<AttractionCategory> _parser = new pb::MessageParser<AttractionCategory>(() => new AttractionCategory());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<AttractionCategory> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Operations.Attractions.AttractionCategoryReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AttractionCategory() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AttractionCategory(AttractionCategory other) : this() {
      EntityId = other.entityId_ != null ? other.EntityId.Clone() : null;
      name_ = other.name_;
      attractions_ = other.attractions_.Clone();
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AttractionCategory Clone() {
      return new AttractionCategory(this);
    }

    /// <summary>Field number for the "entity_id" field.</summary>
    public const int EntityIdFieldNumber = 1;
    private global::HOLMS.Types.Operations.Attractions.AttractionCategoryIndicator entityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Operations.Attractions.AttractionCategoryIndicator EntityId {
      get { return entityId_; }
      set {
        entityId_ = value;
      }
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 2;
    private string name_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "attractions" field.</summary>
    public const int AttractionsFieldNumber = 3;
    private static readonly pb::FieldCodec<global::HOLMS.Types.Operations.Attractions.Attraction> _repeated_attractions_codec
        = pb::FieldCodec.ForMessage(26, global::HOLMS.Types.Operations.Attractions.Attraction.Parser);
    private readonly pbc::RepeatedField<global::HOLMS.Types.Operations.Attractions.Attraction> attractions_ = new pbc::RepeatedField<global::HOLMS.Types.Operations.Attractions.Attraction>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::HOLMS.Types.Operations.Attractions.Attraction> Attractions {
      get { return attractions_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as AttractionCategory);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(AttractionCategory other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(EntityId, other.EntityId)) return false;
      if (Name != other.Name) return false;
      if(!attractions_.Equals(other.attractions_)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (entityId_ != null) hash ^= EntityId.GetHashCode();
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      hash ^= attractions_.GetHashCode();
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
      if (Name.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Name);
      }
      attractions_.WriteTo(output, _repeated_attractions_codec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (entityId_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(EntityId);
      }
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      size += attractions_.CalculateSize(_repeated_attractions_codec);
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(AttractionCategory other) {
      if (other == null) {
        return;
      }
      if (other.entityId_ != null) {
        if (entityId_ == null) {
          entityId_ = new global::HOLMS.Types.Operations.Attractions.AttractionCategoryIndicator();
        }
        EntityId.MergeFrom(other.EntityId);
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      attractions_.Add(other.attractions_);
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
              entityId_ = new global::HOLMS.Types.Operations.Attractions.AttractionCategoryIndicator();
            }
            input.ReadMessage(entityId_);
            break;
          }
          case 18: {
            Name = input.ReadString();
            break;
          }
          case 26: {
            attractions_.AddEntriesFrom(input, _repeated_attractions_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
