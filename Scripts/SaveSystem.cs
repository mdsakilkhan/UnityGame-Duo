using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveSystem {
	
	public static void SavePlayer(DataClass ds) {
		BinaryFormatter formatter = new BinaryFormatter();
		string path = Application.persistentDataPath + "/duo.sakil";
		FileStream stream = new FileStream(path, FileMode.Create);
		PlayerData data = new PlayerData(ds);
		formatter.Serialize(stream,data);
		stream.Close();
	}
	
	public static PlayerData LoadPlayer() {
		string path = Application.persistentDataPath + "/duo.sakil";
		if(File.Exists(path)) {
			BinaryFormatter formatter = new BinaryFormatter();
			FileStream stream = new FileStream(path, FileMode.Open);
			PlayerData data = formatter.Deserialize(stream) as PlayerData;
			stream.Close();
			return data;
		}
		else {
			return null;
		}
	}
}
