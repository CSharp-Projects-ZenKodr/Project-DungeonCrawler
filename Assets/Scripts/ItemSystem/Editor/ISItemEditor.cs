using UnityEngine;
using UnityEditor;
using CaptainSly.Generics;

namespace CaptainSly.ItemSystem.Editor
{
	public class ISItemEditor : EditorWindow
	{
		GenericDatabase<ISObject> itemDatabase;
		ISObject selectedItem;
		Texture2D selectedTexture;

		const int SPRITE_BUTTON_SIZE = 92;

		const string DATABASE_FILE = @"ItemDatabase.asset";
		const string DATABASE_FOLDER_NAME = @"Database";
		const string DATABASE_FULL_PATH = "Assets/" + DATABASE_FOLDER_NAME + "/" + DATABASE_FILE;

		[MenuItem("DungeonCrawler/Database/Item Editor %#U")]
		public static void Init()
		{
			ISItemEditor window = EditorWindow.GetWindow<ISItemEditor>();
			window.minSize = new Vector2(400, 300);
			window.titleContent = new GUIContent("Item Editor");
			window.Show();
		}

		private void OnEnable()
		{
			if (itemDatabase == null)
			{

				if (!AssetDatabase.IsValidFolder("Assets/" + DATABASE_FOLDER_NAME))
					AssetDatabase.CreateFolder("Assets", DATABASE_FOLDER_NAME);

				itemDatabase = ScriptableObject.CreateInstance<ISItemDatabase>();

				AssetDatabase.CreateAsset(itemDatabase, DATABASE_FULL_PATH);
				AssetDatabase.SaveAssets();
				AssetDatabase.Refresh();

			}

			itemDatabase = AssetDatabase.LoadAssetAtPath(DATABASE_FULL_PATH, typeof(ISItemDatabase)) as ISItemDatabase;
			selectedItem = new ISObject();
		}

		private void OnGUI()
		{
			AddItem();
		}

		private void AddItem()
		{
			// Name - TextField
			// Gold Value - IntField
			// Icon - Texture
			// Short Description - TextField
			// Long Description - TextArea
			// Rarity - SwitchBox
			// QuestItem Flag - SwitchBox
		}

	}
}