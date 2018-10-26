// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: IndexedLocation.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from IndexedLocation.proto</summary>
public static partial class IndexedLocationReflection {

  #region Descriptor
  /// <summary>File descriptor for IndexedLocation.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static IndexedLocationReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChVJbmRleGVkTG9jYXRpb24ucHJvdG8iMQoWSW5kZXhlZExvY2F0aW9uUmVx",
          "dWVzdBIXCg9JbmRleGVkTG9jYXRpb24YASABKAkiQQoXSW5kZXhlZExvY2F0",
          "aW9uUmVzcG9uc2USFwoPSW5kZXhlZExvY2F0aW9uGAEgASgJEg0KBUVycm9y",
          "GAIgASgJIj8KGEluZGV4ZWRMb2NhdGlvblN0cnVjdHVyZRIKCgJpZBgBIAEo",
          "CRIXCg9JbmRleGVkTG9jYXRpb24YAiABKAliBnByb3RvMw=="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::IndexedLocationRequest), global::IndexedLocationRequest.Parser, new[]{ "IndexedLocation" }, null, null, null),
          new pbr::GeneratedClrTypeInfo(typeof(global::IndexedLocationResponse), global::IndexedLocationResponse.Parser, new[]{ "IndexedLocation", "Error" }, null, null, null),
          new pbr::GeneratedClrTypeInfo(typeof(global::IndexedLocationStructure), global::IndexedLocationStructure.Parser, new[]{ "Id", "IndexedLocation" }, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class IndexedLocationRequest : pb::IMessage<IndexedLocationRequest> {
  private static readonly pb::MessageParser<IndexedLocationRequest> _parser = new pb::MessageParser<IndexedLocationRequest>(() => new IndexedLocationRequest());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<IndexedLocationRequest> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::IndexedLocationReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public IndexedLocationRequest() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public IndexedLocationRequest(IndexedLocationRequest other) : this() {
    indexedLocation_ = other.indexedLocation_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public IndexedLocationRequest Clone() {
    return new IndexedLocationRequest(this);
  }

  /// <summary>Field number for the "IndexedLocation" field.</summary>
  public const int IndexedLocationFieldNumber = 1;
  private string indexedLocation_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string IndexedLocation {
    get { return indexedLocation_; }
    set {
      indexedLocation_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as IndexedLocationRequest);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(IndexedLocationRequest other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (IndexedLocation != other.IndexedLocation) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (IndexedLocation.Length != 0) hash ^= IndexedLocation.GetHashCode();
    if (_unknownFields != null) {
      hash ^= _unknownFields.GetHashCode();
    }
    return hash;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override string ToString() {
    return pb::JsonFormatter.ToDiagnosticString(this);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void WriteTo(pb::CodedOutputStream output) {
    if (IndexedLocation.Length != 0) {
      output.WriteRawTag(10);
      output.WriteString(IndexedLocation);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    if (IndexedLocation.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(IndexedLocation);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(IndexedLocationRequest other) {
    if (other == null) {
      return;
    }
    if (other.IndexedLocation.Length != 0) {
      IndexedLocation = other.IndexedLocation;
    }
    _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(pb::CodedInputStream input) {
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
          break;
        case 10: {
          IndexedLocation = input.ReadString();
          break;
        }
      }
    }
  }

}

public sealed partial class IndexedLocationResponse : pb::IMessage<IndexedLocationResponse> {
  private static readonly pb::MessageParser<IndexedLocationResponse> _parser = new pb::MessageParser<IndexedLocationResponse>(() => new IndexedLocationResponse());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<IndexedLocationResponse> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::IndexedLocationReflection.Descriptor.MessageTypes[1]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public IndexedLocationResponse() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public IndexedLocationResponse(IndexedLocationResponse other) : this() {
    indexedLocation_ = other.indexedLocation_;
    error_ = other.error_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public IndexedLocationResponse Clone() {
    return new IndexedLocationResponse(this);
  }

  /// <summary>Field number for the "IndexedLocation" field.</summary>
  public const int IndexedLocationFieldNumber = 1;
  private string indexedLocation_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string IndexedLocation {
    get { return indexedLocation_; }
    set {
      indexedLocation_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "Error" field.</summary>
  public const int ErrorFieldNumber = 2;
  private string error_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string Error {
    get { return error_; }
    set {
      error_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as IndexedLocationResponse);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(IndexedLocationResponse other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (IndexedLocation != other.IndexedLocation) return false;
    if (Error != other.Error) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (IndexedLocation.Length != 0) hash ^= IndexedLocation.GetHashCode();
    if (Error.Length != 0) hash ^= Error.GetHashCode();
    if (_unknownFields != null) {
      hash ^= _unknownFields.GetHashCode();
    }
    return hash;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override string ToString() {
    return pb::JsonFormatter.ToDiagnosticString(this);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void WriteTo(pb::CodedOutputStream output) {
    if (IndexedLocation.Length != 0) {
      output.WriteRawTag(10);
      output.WriteString(IndexedLocation);
    }
    if (Error.Length != 0) {
      output.WriteRawTag(18);
      output.WriteString(Error);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    if (IndexedLocation.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(IndexedLocation);
    }
    if (Error.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(Error);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(IndexedLocationResponse other) {
    if (other == null) {
      return;
    }
    if (other.IndexedLocation.Length != 0) {
      IndexedLocation = other.IndexedLocation;
    }
    if (other.Error.Length != 0) {
      Error = other.Error;
    }
    _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(pb::CodedInputStream input) {
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
          break;
        case 10: {
          IndexedLocation = input.ReadString();
          break;
        }
        case 18: {
          Error = input.ReadString();
          break;
        }
      }
    }
  }

}

public sealed partial class IndexedLocationStructure : pb::IMessage<IndexedLocationStructure> {
  private static readonly pb::MessageParser<IndexedLocationStructure> _parser = new pb::MessageParser<IndexedLocationStructure>(() => new IndexedLocationStructure());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<IndexedLocationStructure> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::IndexedLocationReflection.Descriptor.MessageTypes[2]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public IndexedLocationStructure() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public IndexedLocationStructure(IndexedLocationStructure other) : this() {
    id_ = other.id_;
    indexedLocation_ = other.indexedLocation_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public IndexedLocationStructure Clone() {
    return new IndexedLocationStructure(this);
  }

  /// <summary>Field number for the "id" field.</summary>
  public const int IdFieldNumber = 1;
  private string id_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string Id {
    get { return id_; }
    set {
      id_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "IndexedLocation" field.</summary>
  public const int IndexedLocationFieldNumber = 2;
  private string indexedLocation_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string IndexedLocation {
    get { return indexedLocation_; }
    set {
      indexedLocation_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as IndexedLocationStructure);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(IndexedLocationStructure other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (Id != other.Id) return false;
    if (IndexedLocation != other.IndexedLocation) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (Id.Length != 0) hash ^= Id.GetHashCode();
    if (IndexedLocation.Length != 0) hash ^= IndexedLocation.GetHashCode();
    if (_unknownFields != null) {
      hash ^= _unknownFields.GetHashCode();
    }
    return hash;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override string ToString() {
    return pb::JsonFormatter.ToDiagnosticString(this);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void WriteTo(pb::CodedOutputStream output) {
    if (Id.Length != 0) {
      output.WriteRawTag(10);
      output.WriteString(Id);
    }
    if (IndexedLocation.Length != 0) {
      output.WriteRawTag(18);
      output.WriteString(IndexedLocation);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    if (Id.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(Id);
    }
    if (IndexedLocation.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(IndexedLocation);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(IndexedLocationStructure other) {
    if (other == null) {
      return;
    }
    if (other.Id.Length != 0) {
      Id = other.Id;
    }
    if (other.IndexedLocation.Length != 0) {
      IndexedLocation = other.IndexedLocation;
    }
    _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(pb::CodedInputStream input) {
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
          break;
        case 10: {
          Id = input.ReadString();
          break;
        }
        case 18: {
          IndexedLocation = input.ReadString();
          break;
        }
      }
    }
  }

}

#endregion


#endregion Designer generated code
