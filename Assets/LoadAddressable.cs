using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;

public class LoadAddressable : MonoBehaviour
{ 
    async void Start()
    {
        // Addresables 初期化
        await Addressables.InitializeAsync().Task;

        // リモートカタログに変更があれば更新する
        var catalogs = await Addressables.CheckForCatalogUpdates(true).Task;
        if (catalogs != null && catalogs.Count > 0)
        {
            var locators = await Addressables.UpdateCatalogs(catalogs, true).Task;
        }
        
        var prefab = await Addressables.LoadAssetAsync<GameObject>("Assets/Methoko/methoko_1st.prefab").Task;
        Instantiate(prefab, new Vector3(0.0f, 0.0f , -8.0f), Quaternion.Euler(0f, 180f, 0f));
    }

    void Update()
    {
        
    }
}
