using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MapGenerator : MonoBehaviour
{
    
    // マップの大きさ
    [SerializeField]
    private int MAP_SIZE_X = 9;
    [SerializeField]
    private int MAP_SIZE_Y = 9;

    // マップチップを画面に表示するときの大きさ
    [SerializeField]
    private int CHIP_WIDTH = 1;
    [SerializeField]
    private int CHIP_HEIGHT = 1;
    

    //タイルスプライト
    [SerializeField]
    private Material[] tileSprite = null;

    // タイルチップのマップ
    private int[,] map;

    [SerializeField]
    GameObject tileOriginal = null;

    [SerializeField]
    Transform tileParent = null;


    void Start () {
        this.map = new int[,] {
                { 1, 1, 1, 1, 1, 1, 1, 1, 1 },
                { 1, 0, 1, 1, 1, 1, 1, 1, 1 },
                { 1, 1, 1, 1, 1, 1, 1, 1, 1 },
                { 1, 1, 1, 1, 1, 1, 1, 1, 1 },
                { 1, 1, 1, 1, 1, 1, 1, 1, 1 },
                { 1, 1, 1, 1, 1, 1, 1, 1, 1 },
                { 1, 1, 1, 1, 1, 1, 1, 1, 1 },
                { 1, 1, 1, 1, 1, 1, 1, 1, 1 },
                { 1, 1, 1, 1, 1, 1, 1, 1, 1 },
                { 1, 1, 1, 1, 1, 1, 1, 1, 1 }
        };

        for (int y = 0; y < MAP_SIZE_Y; y++)
        {
            for (int x = MAP_SIZE_X - 1; x >= 0; x--)
            {
                if (map[y, x] != 0)
                {
                    // チップの番号に応じたスプライトの取得
                    Material mat = tileSprite[0];

                    // タイルチップを配置する座標の計算
                    Vector3 vec = new Vector3(CHIP_HEIGHT * y,
                        0f,
                        CHIP_WIDTH * x);

                    GameObject instance = (GameObject)Instantiate(tileOriginal);
                    instance.transform.SetParent(tileParent);
                    instance.transform.localPosition = vec;
                    instance.GetComponent<MeshRenderer>().material = mat;
                    instance.SetActive(true);
                }
            }
        }
    }
	
	void Update () {
		
	}
}
