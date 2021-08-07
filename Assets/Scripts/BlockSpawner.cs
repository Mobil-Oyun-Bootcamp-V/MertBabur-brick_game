using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockSpawner : MonoBehaviour
{
    [SerializeField] private Block blockPrefab;

    private int _playWidht = 8;
    private float _distanceBetweenBlock = 0.7f;
    private int _rowSpawned;

    private List<Block> _blockSpawned = new List<Block>();
    
    private void OnEnable()
    {
        for (int i = 0; i < 1; i++)
        {
            SpawnRowOfBlocks();
        }
    }

    /**
     * Küpleri sahne de random şekilde spawn eder
     */
    public void SpawnRowOfBlocks()
    {
        foreach (var block in _blockSpawned)
        {
            if (block != null)
            {
                block.transform.position += Vector3.down * _distanceBetweenBlock;
            }
        }
        
        for (int i = 0; i < _playWidht; i++)
        {
            if (UnityEngine.Random.Range(0, 100) <= 30)
            {
                var block = Instantiate(blockPrefab, GetPosition(i), Quaternion.identity);
                int hits = UnityEngine.Random.Range(1, 3) + _rowSpawned;

                block.SetHits(hits);
                
                _blockSpawned.Add(block);
            }
        }

        _rowSpawned++;
    }

    /**
     * Küpün pozisyonunu döndürür
     */
    private Vector3 GetPosition(int i)
    {
        Vector3 position = transform.position;
        position += Vector3.right * i * _distanceBetweenBlock;
        return position;
    }

    
    
    
}
