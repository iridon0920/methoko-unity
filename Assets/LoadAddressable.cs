using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;

public class LoadAddressable : MonoBehaviour
{ 
    async void Start()
    {
        var prefab = await Addressables.LoadAssetAsync<GameObject>("Assets/Methoko/methoko_1st.prefab").Task;
        Instantiate(prefab, new Vector3(0.0f, 0.0f , -8.0f), Quaternion.Euler(0f, 180f, 0f));
    }

    void Update()
    {
        
    }
}
