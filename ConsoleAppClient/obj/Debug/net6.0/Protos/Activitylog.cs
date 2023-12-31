// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/activitylog.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace GrpcService {

  /// <summary>Holder for reflection information generated from Protos/activitylog.proto</summary>
  public static partial class ActivitylogReflection {

    #region Descriptor
    /// <summary>File descriptor for Protos/activitylog.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ActivitylogReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChhQcm90b3MvYWN0aXZpdHlsb2cucHJvdG8SC2FjdGl2aXR5bG9nGh9nb29n",
            "bGUvcHJvdG9idWYvdGltZXN0YW1wLnByb3RvIs0BChBBY3Rpdml0eUxvZ01v",
            "ZGVsEgsKA09pZBgBIAEoCRIuCgpkSW5wdXREYXRlGAIgASgLMhouZ29vZ2xl",
            "LnByb3RvYnVmLlRpbWVzdGFtcBIPCgdMb2dUeXBlGAMgASgJEhEKCUxvZ0Fj",
            "dGlvbhgEIAEoCRIQCghMb2dWYWx1ZRgFIAEoBRIWCg5Mb2dEZXNjcmlwdGlv",
            "bhgGIAEoCRIWCg5NZXRhX0lQQWRkcmVzcxgHIAEoCRIWCg5NZXRhX0xpY2Vu",
            "c2VJRBgIIAEoCSJNChNBY3Rpdml0eUxvZ1Jlc3BvbnNlEhIKClN0YXR1c0Nv",
            "ZGUYASABKAUSDwoHbWVzc2FnZRgCIAEoCRIRCglJc1N1Y2Nlc3MYAyABKAgy",
            "WAoLQWN0aXZpdHlMb2cSSQoGSW5zZXJ0Eh0uYWN0aXZpdHlsb2cuQWN0aXZp",
            "dHlMb2dNb2RlbBogLmFjdGl2aXR5bG9nLkFjdGl2aXR5TG9nUmVzcG9uc2VC",
            "DqoCC0dycGNTZXJ2aWNlYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::GrpcService.ActivityLogModel), global::GrpcService.ActivityLogModel.Parser, new[]{ "Oid", "DInputDate", "LogType", "LogAction", "LogValue", "LogDescription", "MetaIPAddress", "MetaLicenseID" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::GrpcService.ActivityLogResponse), global::GrpcService.ActivityLogResponse.Parser, new[]{ "StatusCode", "Message", "IsSuccess" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ActivityLogModel : pb::IMessage<ActivityLogModel>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ActivityLogModel> _parser = new pb::MessageParser<ActivityLogModel>(() => new ActivityLogModel());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ActivityLogModel> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GrpcService.ActivitylogReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ActivityLogModel() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ActivityLogModel(ActivityLogModel other) : this() {
      oid_ = other.oid_;
      dInputDate_ = other.dInputDate_ != null ? other.dInputDate_.Clone() : null;
      logType_ = other.logType_;
      logAction_ = other.logAction_;
      logValue_ = other.logValue_;
      logDescription_ = other.logDescription_;
      metaIPAddress_ = other.metaIPAddress_;
      metaLicenseID_ = other.metaLicenseID_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ActivityLogModel Clone() {
      return new ActivityLogModel(this);
    }

    /// <summary>Field number for the "Oid" field.</summary>
    public const int OidFieldNumber = 1;
    private string oid_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Oid {
      get { return oid_; }
      set {
        oid_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "dInputDate" field.</summary>
    public const int DInputDateFieldNumber = 2;
    private global::Google.Protobuf.WellKnownTypes.Timestamp dInputDate_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Protobuf.WellKnownTypes.Timestamp DInputDate {
      get { return dInputDate_; }
      set {
        dInputDate_ = value;
      }
    }

    /// <summary>Field number for the "LogType" field.</summary>
    public const int LogTypeFieldNumber = 3;
    private string logType_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string LogType {
      get { return logType_; }
      set {
        logType_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "LogAction" field.</summary>
    public const int LogActionFieldNumber = 4;
    private string logAction_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string LogAction {
      get { return logAction_; }
      set {
        logAction_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "LogValue" field.</summary>
    public const int LogValueFieldNumber = 5;
    private int logValue_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int LogValue {
      get { return logValue_; }
      set {
        logValue_ = value;
      }
    }

    /// <summary>Field number for the "LogDescription" field.</summary>
    public const int LogDescriptionFieldNumber = 6;
    private string logDescription_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string LogDescription {
      get { return logDescription_; }
      set {
        logDescription_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "Meta_IPAddress" field.</summary>
    public const int MetaIPAddressFieldNumber = 7;
    private string metaIPAddress_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string MetaIPAddress {
      get { return metaIPAddress_; }
      set {
        metaIPAddress_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "Meta_LicenseID" field.</summary>
    public const int MetaLicenseIDFieldNumber = 8;
    private string metaLicenseID_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string MetaLicenseID {
      get { return metaLicenseID_; }
      set {
        metaLicenseID_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ActivityLogModel);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ActivityLogModel other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Oid != other.Oid) return false;
      if (!object.Equals(DInputDate, other.DInputDate)) return false;
      if (LogType != other.LogType) return false;
      if (LogAction != other.LogAction) return false;
      if (LogValue != other.LogValue) return false;
      if (LogDescription != other.LogDescription) return false;
      if (MetaIPAddress != other.MetaIPAddress) return false;
      if (MetaLicenseID != other.MetaLicenseID) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Oid.Length != 0) hash ^= Oid.GetHashCode();
      if (dInputDate_ != null) hash ^= DInputDate.GetHashCode();
      if (LogType.Length != 0) hash ^= LogType.GetHashCode();
      if (LogAction.Length != 0) hash ^= LogAction.GetHashCode();
      if (LogValue != 0) hash ^= LogValue.GetHashCode();
      if (LogDescription.Length != 0) hash ^= LogDescription.GetHashCode();
      if (MetaIPAddress.Length != 0) hash ^= MetaIPAddress.GetHashCode();
      if (MetaLicenseID.Length != 0) hash ^= MetaLicenseID.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (Oid.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Oid);
      }
      if (dInputDate_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(DInputDate);
      }
      if (LogType.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(LogType);
      }
      if (LogAction.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(LogAction);
      }
      if (LogValue != 0) {
        output.WriteRawTag(40);
        output.WriteInt32(LogValue);
      }
      if (LogDescription.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(LogDescription);
      }
      if (MetaIPAddress.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(MetaIPAddress);
      }
      if (MetaLicenseID.Length != 0) {
        output.WriteRawTag(66);
        output.WriteString(MetaLicenseID);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Oid.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Oid);
      }
      if (dInputDate_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(DInputDate);
      }
      if (LogType.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(LogType);
      }
      if (LogAction.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(LogAction);
      }
      if (LogValue != 0) {
        output.WriteRawTag(40);
        output.WriteInt32(LogValue);
      }
      if (LogDescription.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(LogDescription);
      }
      if (MetaIPAddress.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(MetaIPAddress);
      }
      if (MetaLicenseID.Length != 0) {
        output.WriteRawTag(66);
        output.WriteString(MetaLicenseID);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (Oid.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Oid);
      }
      if (dInputDate_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(DInputDate);
      }
      if (LogType.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(LogType);
      }
      if (LogAction.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(LogAction);
      }
      if (LogValue != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(LogValue);
      }
      if (LogDescription.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(LogDescription);
      }
      if (MetaIPAddress.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(MetaIPAddress);
      }
      if (MetaLicenseID.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(MetaLicenseID);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ActivityLogModel other) {
      if (other == null) {
        return;
      }
      if (other.Oid.Length != 0) {
        Oid = other.Oid;
      }
      if (other.dInputDate_ != null) {
        if (dInputDate_ == null) {
          DInputDate = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        DInputDate.MergeFrom(other.DInputDate);
      }
      if (other.LogType.Length != 0) {
        LogType = other.LogType;
      }
      if (other.LogAction.Length != 0) {
        LogAction = other.LogAction;
      }
      if (other.LogValue != 0) {
        LogValue = other.LogValue;
      }
      if (other.LogDescription.Length != 0) {
        LogDescription = other.LogDescription;
      }
      if (other.MetaIPAddress.Length != 0) {
        MetaIPAddress = other.MetaIPAddress;
      }
      if (other.MetaLicenseID.Length != 0) {
        MetaLicenseID = other.MetaLicenseID;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Oid = input.ReadString();
            break;
          }
          case 18: {
            if (dInputDate_ == null) {
              DInputDate = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(DInputDate);
            break;
          }
          case 26: {
            LogType = input.ReadString();
            break;
          }
          case 34: {
            LogAction = input.ReadString();
            break;
          }
          case 40: {
            LogValue = input.ReadInt32();
            break;
          }
          case 50: {
            LogDescription = input.ReadString();
            break;
          }
          case 58: {
            MetaIPAddress = input.ReadString();
            break;
          }
          case 66: {
            MetaLicenseID = input.ReadString();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            Oid = input.ReadString();
            break;
          }
          case 18: {
            if (dInputDate_ == null) {
              DInputDate = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(DInputDate);
            break;
          }
          case 26: {
            LogType = input.ReadString();
            break;
          }
          case 34: {
            LogAction = input.ReadString();
            break;
          }
          case 40: {
            LogValue = input.ReadInt32();
            break;
          }
          case 50: {
            LogDescription = input.ReadString();
            break;
          }
          case 58: {
            MetaIPAddress = input.ReadString();
            break;
          }
          case 66: {
            MetaLicenseID = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class ActivityLogResponse : pb::IMessage<ActivityLogResponse>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ActivityLogResponse> _parser = new pb::MessageParser<ActivityLogResponse>(() => new ActivityLogResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ActivityLogResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GrpcService.ActivitylogReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ActivityLogResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ActivityLogResponse(ActivityLogResponse other) : this() {
      statusCode_ = other.statusCode_;
      message_ = other.message_;
      isSuccess_ = other.isSuccess_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ActivityLogResponse Clone() {
      return new ActivityLogResponse(this);
    }

    /// <summary>Field number for the "StatusCode" field.</summary>
    public const int StatusCodeFieldNumber = 1;
    private int statusCode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int StatusCode {
      get { return statusCode_; }
      set {
        statusCode_ = value;
      }
    }

    /// <summary>Field number for the "message" field.</summary>
    public const int MessageFieldNumber = 2;
    private string message_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Message {
      get { return message_; }
      set {
        message_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "IsSuccess" field.</summary>
    public const int IsSuccessFieldNumber = 3;
    private bool isSuccess_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsSuccess {
      get { return isSuccess_; }
      set {
        isSuccess_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ActivityLogResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ActivityLogResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (StatusCode != other.StatusCode) return false;
      if (Message != other.Message) return false;
      if (IsSuccess != other.IsSuccess) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (StatusCode != 0) hash ^= StatusCode.GetHashCode();
      if (Message.Length != 0) hash ^= Message.GetHashCode();
      if (IsSuccess != false) hash ^= IsSuccess.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (StatusCode != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(StatusCode);
      }
      if (Message.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Message);
      }
      if (IsSuccess != false) {
        output.WriteRawTag(24);
        output.WriteBool(IsSuccess);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (StatusCode != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(StatusCode);
      }
      if (Message.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Message);
      }
      if (IsSuccess != false) {
        output.WriteRawTag(24);
        output.WriteBool(IsSuccess);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (StatusCode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(StatusCode);
      }
      if (Message.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Message);
      }
      if (IsSuccess != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ActivityLogResponse other) {
      if (other == null) {
        return;
      }
      if (other.StatusCode != 0) {
        StatusCode = other.StatusCode;
      }
      if (other.Message.Length != 0) {
        Message = other.Message;
      }
      if (other.IsSuccess != false) {
        IsSuccess = other.IsSuccess;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            StatusCode = input.ReadInt32();
            break;
          }
          case 18: {
            Message = input.ReadString();
            break;
          }
          case 24: {
            IsSuccess = input.ReadBool();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 8: {
            StatusCode = input.ReadInt32();
            break;
          }
          case 18: {
            Message = input.ReadString();
            break;
          }
          case 24: {
            IsSuccess = input.ReadBool();
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
