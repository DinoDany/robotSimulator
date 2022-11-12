//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Geometry
{
    [Serializable]
    public class PoseMsg : Message
    {
        public const string k_RosMessageName = "geometry_msgs/Pose";
        public override string RosMessageName => k_RosMessageName;

        //  A representation of pose in free space, composed of position and orientation.
        public PointMsg position;
        public QuaternionMsg orientation;

        public PoseMsg()
        {
            this.position = new PointMsg();
            this.orientation = new QuaternionMsg();
        }

        public PoseMsg(PointMsg position, QuaternionMsg orientation)
        {
            this.position = position;
            this.orientation = orientation;
        }

        public static PoseMsg Deserialize(MessageDeserializer deserializer) => new PoseMsg(deserializer);

        private PoseMsg(MessageDeserializer deserializer)
        {
            this.position = PointMsg.Deserialize(deserializer);
            this.orientation = QuaternionMsg.Deserialize(deserializer);
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.position);
            serializer.Write(this.orientation);
        }

        public override string ToString()
        {
            return "PoseMsg: " +
            "\nposition: " + position.ToString() +
            "\norientation: " + orientation.ToString();
        }

#if UNITY_EDITOR
        [UnityEditor.InitializeOnLoadMethod]
#else
        [UnityEngine.RuntimeInitializeOnLoadMethod]
#endif
        public static void Register()
        {
            MessageRegistry.Register(k_RosMessageName, Deserialize);
        }
    }
}