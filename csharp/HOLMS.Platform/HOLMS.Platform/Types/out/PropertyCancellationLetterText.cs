// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: tenancy_config/property_cancellation_letter_text.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HOLMS.Types.TenancyConfig {

  /// <summary>Holder for reflection information generated from tenancy_config/property_cancellation_letter_text.proto</summary>
  public static partial class PropertyCancellationLetterTextReflection {

    #region Descriptor
    /// <summary>File descriptor for tenancy_config/property_cancellation_letter_text.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PropertyCancellationLetterTextReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjZ0ZW5hbmN5X2NvbmZpZy9wcm9wZXJ0eV9jYW5jZWxsYXRpb25fbGV0dGVy",
            "X3RleHQucHJvdG8SGmhvbG1zLnR5cGVzLnRlbmFuY3lfY29uZmlnGjJ0ZW5h",
            "bmN5X2NvbmZpZy9pbmRpY2F0b3JzL3Byb3BlcnR5X2luZGljYXRvci5wcm90",
            "byKyAQoeUHJvcGVydHlDYW5jZWxsYXRpb25MZXR0ZXJUZXh0EkoKCHByb3Bl",
            "cnR5GAEgASgLMjguaG9sbXMudHlwZXMudGVuYW5jeV9jb25maWcuaW5kaWNh",
            "dG9ycy5Qcm9wZXJ0eUluZGljYXRvchIhChljYW5jZWxsYXRpb25fb3Blbmlu",
            "Z190ZXh0GAIgASgJEiEKGWNhbmNlbGxhdGlvbl9jbG9zaW5nX3RleHQYAyAB",
            "KAlCHKoCGUhPTE1TLlR5cGVzLlRlbmFuY3lDb25maWdiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::HOLMS.Types.TenancyConfig.Indicators.PropertyIndicatorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.TenancyConfig.PropertyCancellationLetterText), global::HOLMS.Types.TenancyConfig.PropertyCancellationLetterText.Parser, new[]{ "Property", "CancellationOpeningText", "CancellationClosingText" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class PropertyCancellationLetterText : pb::IMessage<PropertyCancellationLetterText> {
    private static readonly pb::MessageParser<PropertyCancellationLetterText> _parser = new pb::MessageParser<PropertyCancellationLetterText>(() => new PropertyCancellationLetterText());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PropertyCancellationLetterText> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.TenancyConfig.PropertyCancellationLetterTextReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PropertyCancellationLetterText() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PropertyCancellationLetterText(PropertyCancellationLetterText other) : this() {
      Property = other.property_ != null ? other.Property.Clone() : null;
      cancellationOpeningText_ = other.cancellationOpeningText_;
      cancellationClosingText_ = other.cancellationClosingText_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PropertyCancellationLetterText Clone() {
      return new PropertyCancellationLetterText(this);
    }

    /// <summary>Field number for the "property" field.</summary>
    public const int PropertyFieldNumber = 1;
    private global::HOLMS.Types.TenancyConfig.Indicators.PropertyIndicator property_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.TenancyConfig.Indicators.PropertyIndicator Property {
      get { return property_; }
      set {
        property_ = value;
      }
    }

    /// <summary>Field number for the "cancellation_opening_text" field.</summary>
    public const int CancellationOpeningTextFieldNumber = 2;
    private string cancellationOpeningText_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string CancellationOpeningText {
      get { return cancellationOpeningText_; }
      set {
        cancellationOpeningText_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "cancellation_closing_text" field.</summary>
    public const int CancellationClosingTextFieldNumber = 3;
    private string cancellationClosingText_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string CancellationClosingText {
      get { return cancellationClosingText_; }
      set {
        cancellationClosingText_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PropertyCancellationLetterText);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PropertyCancellationLetterText other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Property, other.Property)) return false;
      if (CancellationOpeningText != other.CancellationOpeningText) return false;
      if (CancellationClosingText != other.CancellationClosingText) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (property_ != null) hash ^= Property.GetHashCode();
      if (CancellationOpeningText.Length != 0) hash ^= CancellationOpeningText.GetHashCode();
      if (CancellationClosingText.Length != 0) hash ^= CancellationClosingText.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (property_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Property);
      }
      if (CancellationOpeningText.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(CancellationOpeningText);
      }
      if (CancellationClosingText.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(CancellationClosingText);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (property_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Property);
      }
      if (CancellationOpeningText.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(CancellationOpeningText);
      }
      if (CancellationClosingText.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(CancellationClosingText);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PropertyCancellationLetterText other) {
      if (other == null) {
        return;
      }
      if (other.property_ != null) {
        if (property_ == null) {
          property_ = new global::HOLMS.Types.TenancyConfig.Indicators.PropertyIndicator();
        }
        Property.MergeFrom(other.Property);
      }
      if (other.CancellationOpeningText.Length != 0) {
        CancellationOpeningText = other.CancellationOpeningText;
      }
      if (other.CancellationClosingText.Length != 0) {
        CancellationClosingText = other.CancellationClosingText;
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
            if (property_ == null) {
              property_ = new global::HOLMS.Types.TenancyConfig.Indicators.PropertyIndicator();
            }
            input.ReadMessage(property_);
            break;
          }
          case 18: {
            CancellationOpeningText = input.ReadString();
            break;
          }
          case 26: {
            CancellationClosingText = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
