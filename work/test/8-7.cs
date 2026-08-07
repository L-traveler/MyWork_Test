//1

List<Dictionary<string, dynamic>> goodsList = new List<Dictionary<string, dynamic>>
            {
                new Dictionary<string, dynamic>
                {
                    {"name", "机械键盘"},
                    {"price", 299.99},
                    {"code", "G001"},
                    {"stock", 120}
                },
                new Dictionary<string, dynamic>
                {
                    {"name", "无线鼠标"},
                    {"price", 89.50},
                    {"code", "G002"},
                    {"stock", 356}
                },
                new Dictionary<string, dynamic>
                {
                    {"name", "27寸显示器"},
                    {"price", 1299.00},
                    {"code", "G003"},
                    {"stock", 48}
                },
                new Dictionary<string, dynamic>
                {
                    {"name", "电竞耳机"},
                    {"price", 199.00},
                    {"code", "G004"},
                    {"stock", 85}
                },
                new Dictionary<string, dynamic>
                {
                    {"name", "电脑支架"},
                    {"price", 69.90},
                    {"code", "G005"},
                    {"stock", 210}
                }
            };


// 按照价格做排序
Console.WriteLine("请选择排序类型（price/stock）");
string paixuleixing = Console.ReadLine();
Console.WriteLine("请选择排序顺序（ASC/DSC）");
string paixushunxu = Console.ReadLine();


if ((paixuleixing == "price" || paixuleixing == "stock") && (paixushunxu == "ASC" || paixushunxu == "DSC"))
{
    if (paixushunxu == "ASC")
    {
        for (int j = 0; j < goodsList.Count - 1; j++)
        {
            for (int i = 0; i < goodsList.Count - 1; i++)
            {
                if (goodsList[i][paixuleixing] > goodsList[i + 1][paixuleixing])
                {
                    var tmp = goodsList[i];
                    goodsList[i] = goodsList[i + 1];
                    goodsList[i + 1] = tmp;
                }

            }
        }
    }
    else if (paixushunxu == "DSC")
    {
        for (int j = 0; j < goodsList.Count - 1; j++)
        {
            for (int i = 0; i < goodsList.Count - 1; i++)
            {
                if (goodsList[i][paixuleixing] < goodsList[i + 1][paixuleixing])
                {
                    var tmp = goodsList[i];
                    goodsList[i] = goodsList[i + 1];
                    goodsList[i + 1] = tmp;
                }

            }
        }
    }

    foreach (var n in goodsList)
    {
        Console.WriteLine(n["name"] + "  " + n[paixuleixing]);
    }
}
else
{
    Console.WriteLine("输入错误");
}






//2

List<Dictionary<string, dynamic>> singerList = new List<Dictionary<string, dynamic>>
            {
                new Dictionary<string, dynamic>
                {
                    {"singerId", 1001},
                    {"singerName", "周杰伦"},
                    {"genre", "流行"}
                },
                new Dictionary<string, dynamic>
                {
                    {"singerId", 1002},
                    {"singerName", "林俊杰"},
                    {"genre", "华语流行"}
                },
                new Dictionary<string, dynamic>
                {
                    {"singerId", 1003},
                    {"singerName", "邓紫棋"},
                    {"genre", "流行、摇滚"}
                },
                new Dictionary<string, dynamic>
                {
                    {"singerId", 1004},
                    {"singerName", "薛之谦"},
                    {"genre", "抒情流行"}
                },
                new Dictionary<string, dynamic>
                {
                    {"singerId", 1005},
                    {"singerName", "毛不易"},
                    {"genre", "民谣流行"}
                }
            };

List<Dictionary<string, dynamic>> songList = new List<Dictionary<string, dynamic>>
            {
                new Dictionary<string, dynamic>
                {
                    {"songId", 10001},
                    {"singerId", 1001},
                    {"songName", "青花瓷"},
                    {"duration", 239}
                },
                new Dictionary<string, dynamic>
                {
                    {"songId", 10002},
                    {"singerId", 1001},
                    {"songName", "发如雪"},
                    {"duration", 253}
                },
                new Dictionary<string, dynamic>
                {
                    {"songId", 10003},
                    {"singerId", 1001},
                    {"songName", "东风破"},
                    {"duration", 215}
                },
                new Dictionary<string, dynamic>
                {
                    {"songId", 1004},
                    {"singerId", 3002},
                    {"songName", "不为谁而作的歌"},
                    {"duration", 296}
                },
                new Dictionary<string, dynamic>
                {
                    {"songId", 1005},
                    {"singerId", 1002},
                    {"songName", "背对背拥抱"},
                    {"duration", 262}
                }
            };

// 数据使用案例中的数据

// 通过歌曲查找歌手
Console.WriteLine("请输入歌曲：");
string song = Console.ReadLine();
int singerSongId = 0;
if (song != null)
{
    foreach (dynamic songs in songList)
    {
        if (songs["songName"] == song)
        {
            singerSongId = songs["singerId"];
        }
    }
    foreach (dynamic singerid in singerList)
    {
        if (singerSongId == singerid["singerId"])
        {
            Console.WriteLine(singerid["singerName"]);
        }

    }
}