// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: TelemetryProtobuf.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace DotNet.Core.IotHub.Models.Protobuf {

  /// <summary>Holder for reflection information generated from TelemetryProtobuf.proto</summary>
  public static partial class TelemetryProtobufReflection {

    #region Descriptor
    /// <summary>File descriptor for TelemetryProtobuf.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TelemetryProtobufReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChdUZWxlbWV0cnlQcm90b2J1Zi5wcm90byKgAQoRVGVsZW1ldHJ5UHJvdG9i",
            "dWYSEAoIZGV2aWNlSWQYASABKAkSEwoLdGVtcGVyYXR1cmUYAiABKAESEAoI",
            "aHVtaWRpdHkYAyABKAESEAoIcHJlc3N1cmUYBCABKAESDQoFbXNnSWQYBSAB",
            "KAUSDQoFbGFiZWwYBiABKAkSEwoLcHJvYmFiaWxpdHkYByABKAESDQoFaW1h",
            "Z2UYCCABKAxCJaoCIkRvdE5ldC5Db3JlLklvdEh1Yi5Nb2RlbHMuUHJvdG9i",
            "dWZiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::DotNet.Core.IotHub.Models.Protobuf.TelemetryProtobuf), global::DotNet.Core.IotHub.Models.Protobuf.TelemetryProtobuf.Parser, new[]{ "DeviceId", "Temperature", "Humidity", "Pressure", "MsgId", "Label", "Probability", "Image" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class TelemetryProtobuf : pb::IMessage<TelemetryProtobuf> {
    private static readonly pb::MessageParser<TelemetryProtobuf> _parser = new pb::MessageParser<TelemetryProtobuf>(() => new TelemetryProtobuf());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<TelemetryProtobuf> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::DotNet.Core.IotHub.Models.Protobuf.TelemetryProtobufReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TelemetryProtobuf() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TelemetryProtobuf(TelemetryProtobuf other) : this() {
      deviceId_ = other.deviceId_;
      temperature_ = other.temperature_;
      humidity_ = other.humidity_;
      pressure_ = other.pressure_;
      msgId_ = other.msgId_;
      label_ = other.label_;
      probability_ = other.probability_;
      image_ = other.image_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TelemetryProtobuf Clone() {
      return new TelemetryProtobuf(this);
    }

    /// <summary>Field number for the "deviceId" field.</summary>
    public const int DeviceIdFieldNumber = 1;
    private string deviceId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string DeviceId {
      get { return deviceId_; }
      set {
        deviceId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "temperature" field.</summary>
    public const int TemperatureFieldNumber = 2;
    private double temperature_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double Temperature {
      get { return temperature_; }
      set {
        temperature_ = value;
      }
    }

    /// <summary>Field number for the "humidity" field.</summary>
    public const int HumidityFieldNumber = 3;
    private double humidity_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double Humidity {
      get { return humidity_; }
      set {
        humidity_ = value;
      }
    }

    /// <summary>Field number for the "pressure" field.</summary>
    public const int PressureFieldNumber = 4;
    private double pressure_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double Pressure {
      get { return pressure_; }
      set {
        pressure_ = value;
      }
    }

    /// <summary>Field number for the "msgId" field.</summary>
    public const int MsgIdFieldNumber = 5;
    private int msgId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int MsgId {
      get { return msgId_; }
      set {
        msgId_ = value;
      }
    }

    /// <summary>Field number for the "label" field.</summary>
    public const int LabelFieldNumber = 6;
    private string label_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Label {
      get { return label_; }
      set {
        label_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "probability" field.</summary>
    public const int ProbabilityFieldNumber = 7;
    private double probability_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double Probability {
      get { return probability_; }
      set {
        probability_ = value;
      }
    }

    /// <summary>Field number for the "image" field.</summary>
    public const int ImageFieldNumber = 8;
    private pb::ByteString image_ = pb::ByteString.Empty;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pb::ByteString Image {
      get { return image_; }
      set {
        image_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as TelemetryProtobuf);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(TelemetryProtobuf other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (DeviceId != other.DeviceId) return false;
      if (Temperature != other.Temperature) return false;
      if (Humidity != other.Humidity) return false;
      if (Pressure != other.Pressure) return false;
      if (MsgId != other.MsgId) return false;
      if (Label != other.Label) return false;
      if (Probability != other.Probability) return false;
      if (Image != other.Image) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (DeviceId.Length != 0) hash ^= DeviceId.GetHashCode();
      if (Temperature != 0D) hash ^= Temperature.GetHashCode();
      if (Humidity != 0D) hash ^= Humidity.GetHashCode();
      if (Pressure != 0D) hash ^= Pressure.GetHashCode();
      if (MsgId != 0) hash ^= MsgId.GetHashCode();
      if (Label.Length != 0) hash ^= Label.GetHashCode();
      if (Probability != 0D) hash ^= Probability.GetHashCode();
      if (Image.Length != 0) hash ^= Image.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (DeviceId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(DeviceId);
      }
      if (Temperature != 0D) {
        output.WriteRawTag(17);
        output.WriteDouble(Temperature);
      }
      if (Humidity != 0D) {
        output.WriteRawTag(25);
        output.WriteDouble(Humidity);
      }
      if (Pressure != 0D) {
        output.WriteRawTag(33);
        output.WriteDouble(Pressure);
      }
      if (MsgId != 0) {
        output.WriteRawTag(40);
        output.WriteInt32(MsgId);
      }
      if (Label.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(Label);
      }
      if (Probability != 0D) {
        output.WriteRawTag(57);
        output.WriteDouble(Probability);
      }
      if (Image.Length != 0) {
        output.WriteRawTag(66);
        output.WriteBytes(Image);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (DeviceId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(DeviceId);
      }
      if (Temperature != 0D) {
        size += 1 + 8;
      }
      if (Humidity != 0D) {
        size += 1 + 8;
      }
      if (Pressure != 0D) {
        size += 1 + 8;
      }
      if (MsgId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(MsgId);
      }
      if (Label.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Label);
      }
      if (Probability != 0D) {
        size += 1 + 8;
      }
      if (Image.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(Image);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(TelemetryProtobuf other) {
      if (other == null) {
        return;
      }
      if (other.DeviceId.Length != 0) {
        DeviceId = other.DeviceId;
      }
      if (other.Temperature != 0D) {
        Temperature = other.Temperature;
      }
      if (other.Humidity != 0D) {
        Humidity = other.Humidity;
      }
      if (other.Pressure != 0D) {
        Pressure = other.Pressure;
      }
      if (other.MsgId != 0) {
        MsgId = other.MsgId;
      }
      if (other.Label.Length != 0) {
        Label = other.Label;
      }
      if (other.Probability != 0D) {
        Probability = other.Probability;
      }
      if (other.Image.Length != 0) {
        Image = other.Image;
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
            DeviceId = input.ReadString();
            break;
          }
          case 17: {
            Temperature = input.ReadDouble();
            break;
          }
          case 25: {
            Humidity = input.ReadDouble();
            break;
          }
          case 33: {
            Pressure = input.ReadDouble();
            break;
          }
          case 40: {
            MsgId = input.ReadInt32();
            break;
          }
          case 50: {
            Label = input.ReadString();
            break;
          }
          case 57: {
            Probability = input.ReadDouble();
            break;
          }
          case 66: {
            Image = input.ReadBytes();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
