// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: supply/packages/lodging_package.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HOLMS.Types.Supply.Packages {

  /// <summary>Holder for reflection information generated from supply/packages/lodging_package.proto</summary>
  public static partial class LodgingPackageReflection {

    #region Descriptor
    /// <summary>File descriptor for supply/packages/lodging_package.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static LodgingPackageReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiVzdXBwbHkvcGFja2FnZXMvbG9kZ2luZ19wYWNrYWdlLnByb3RvEhtob2xt",
            "cy50eXBlcy5zdXBwbHkucGFja2FnZXMaH2dvb2dsZS9wcm90b2J1Zi90aW1l",
            "c3RhbXAucHJvdG8aI3N1cHBseS9wcmljZWRfb2ZmZXJlZF9sb2RnaW5nLnBy",
            "b3RvGi9zdXBwbHkvcGFja2FnZXMvbG9kZ2luZ19wYWNrYWdlX2luZGljYXRv",
            "ci5wcm90byL3AQoOTG9kZ2luZ1BhY2thZ2USEAoIYm9va2FibGUYASABKAgS",
            "HwoXYm9va2FibGVfd2l0aF9ob2xkX2Ryb3AYAiABKAgSOAoGb2ZmZXJzGAMg",
            "AygLMiguaG9sbXMudHlwZXMuc3VwcGx5LlByaWNlZE9mZmVyZWRMb2RnaW5n",
            "EkgKCnBhY2thZ2VfaWQYBCABKAsyNC5ob2xtcy50eXBlcy5zdXBwbHkucGFj",
            "a2FnZXMuTG9kZ2luZ1BhY2thZ2VJbmRpY2F0b3ISLgoKZXhwaXJlc19hdBgF",
            "IAEoCzIaLmdvb2dsZS5wcm90b2J1Zi5UaW1lc3RhbXBCHqoCG0hPTE1TLlR5",
            "cGVzLlN1cHBseS5QYWNrYWdlc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, global::HOLMS.Types.Supply.PricedOfferedLodgingReflection.Descriptor, global::HOLMS.Types.Supply.Packages.LodgingPackageIndicatorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::HOLMS.Types.Supply.Packages.LodgingPackage), global::HOLMS.Types.Supply.Packages.LodgingPackage.Parser, new[]{ "Bookable", "BookableWithHoldDrop", "Offers", "PackageId", "ExpiresAt" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class LodgingPackage : pb::IMessage<LodgingPackage> {
    private static readonly pb::MessageParser<LodgingPackage> _parser = new pb::MessageParser<LodgingPackage>(() => new LodgingPackage());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<LodgingPackage> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HOLMS.Types.Supply.Packages.LodgingPackageReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LodgingPackage() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LodgingPackage(LodgingPackage other) : this() {
      bookable_ = other.bookable_;
      bookableWithHoldDrop_ = other.bookableWithHoldDrop_;
      offers_ = other.offers_.Clone();
      PackageId = other.packageId_ != null ? other.PackageId.Clone() : null;
      ExpiresAt = other.expiresAt_ != null ? other.ExpiresAt.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LodgingPackage Clone() {
      return new LodgingPackage(this);
    }

    /// <summary>Field number for the "bookable" field.</summary>
    public const int BookableFieldNumber = 1;
    private bool bookable_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Bookable {
      get { return bookable_; }
      set {
        bookable_ = value;
      }
    }

    /// <summary>Field number for the "bookable_with_hold_drop" field.</summary>
    public const int BookableWithHoldDropFieldNumber = 2;
    private bool bookableWithHoldDrop_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool BookableWithHoldDrop {
      get { return bookableWithHoldDrop_; }
      set {
        bookableWithHoldDrop_ = value;
      }
    }

    /// <summary>Field number for the "offers" field.</summary>
    public const int OffersFieldNumber = 3;
    private static readonly pb::FieldCodec<global::HOLMS.Types.Supply.PricedOfferedLodging> _repeated_offers_codec
        = pb::FieldCodec.ForMessage(26, global::HOLMS.Types.Supply.PricedOfferedLodging.Parser);
    private readonly pbc::RepeatedField<global::HOLMS.Types.Supply.PricedOfferedLodging> offers_ = new pbc::RepeatedField<global::HOLMS.Types.Supply.PricedOfferedLodging>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::HOLMS.Types.Supply.PricedOfferedLodging> Offers {
      get { return offers_; }
    }

    /// <summary>Field number for the "package_id" field.</summary>
    public const int PackageIdFieldNumber = 4;
    private global::HOLMS.Types.Supply.Packages.LodgingPackageIndicator packageId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HOLMS.Types.Supply.Packages.LodgingPackageIndicator PackageId {
      get { return packageId_; }
      set {
        packageId_ = value;
      }
    }

    /// <summary>Field number for the "expires_at" field.</summary>
    public const int ExpiresAtFieldNumber = 5;
    private global::Google.Protobuf.WellKnownTypes.Timestamp expiresAt_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Timestamp ExpiresAt {
      get { return expiresAt_; }
      set {
        expiresAt_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as LodgingPackage);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(LodgingPackage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Bookable != other.Bookable) return false;
      if (BookableWithHoldDrop != other.BookableWithHoldDrop) return false;
      if(!offers_.Equals(other.offers_)) return false;
      if (!object.Equals(PackageId, other.PackageId)) return false;
      if (!object.Equals(ExpiresAt, other.ExpiresAt)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Bookable != false) hash ^= Bookable.GetHashCode();
      if (BookableWithHoldDrop != false) hash ^= BookableWithHoldDrop.GetHashCode();
      hash ^= offers_.GetHashCode();
      if (packageId_ != null) hash ^= PackageId.GetHashCode();
      if (expiresAt_ != null) hash ^= ExpiresAt.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Bookable != false) {
        output.WriteRawTag(8);
        output.WriteBool(Bookable);
      }
      if (BookableWithHoldDrop != false) {
        output.WriteRawTag(16);
        output.WriteBool(BookableWithHoldDrop);
      }
      offers_.WriteTo(output, _repeated_offers_codec);
      if (packageId_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(PackageId);
      }
      if (expiresAt_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(ExpiresAt);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Bookable != false) {
        size += 1 + 1;
      }
      if (BookableWithHoldDrop != false) {
        size += 1 + 1;
      }
      size += offers_.CalculateSize(_repeated_offers_codec);
      if (packageId_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(PackageId);
      }
      if (expiresAt_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ExpiresAt);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(LodgingPackage other) {
      if (other == null) {
        return;
      }
      if (other.Bookable != false) {
        Bookable = other.Bookable;
      }
      if (other.BookableWithHoldDrop != false) {
        BookableWithHoldDrop = other.BookableWithHoldDrop;
      }
      offers_.Add(other.offers_);
      if (other.packageId_ != null) {
        if (packageId_ == null) {
          packageId_ = new global::HOLMS.Types.Supply.Packages.LodgingPackageIndicator();
        }
        PackageId.MergeFrom(other.PackageId);
      }
      if (other.expiresAt_ != null) {
        if (expiresAt_ == null) {
          expiresAt_ = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        ExpiresAt.MergeFrom(other.ExpiresAt);
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
            Bookable = input.ReadBool();
            break;
          }
          case 16: {
            BookableWithHoldDrop = input.ReadBool();
            break;
          }
          case 26: {
            offers_.AddEntriesFrom(input, _repeated_offers_codec);
            break;
          }
          case 34: {
            if (packageId_ == null) {
              packageId_ = new global::HOLMS.Types.Supply.Packages.LodgingPackageIndicator();
            }
            input.ReadMessage(packageId_);
            break;
          }
          case 42: {
            if (expiresAt_ == null) {
              expiresAt_ = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(expiresAt_);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
