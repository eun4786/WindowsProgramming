using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Watics.Models;

namespace Watics.Factories
{
    public class ItemList
    {
        private List<GameItem> _currentItemList;

        public ItemList()
        {
            _currentItemList = new List<GameItem>();
            //GameData\Items 텍스트 파일로부터 아이템 목록 읽어오기
            string line;
            bool checkForReadStart = true;
            bool startReading = false;



            System.IO.StreamReader file =
                //경로 수정 필요
                new System.IO.StreamReader("C:\\Users\\Test01\\source\repos\\WPG\\Watics\\GameData\\Items\\ItemList.txt");
            while ((line = file.ReadLine()) != null)
            {
                //look for the position to start reading designated by "##"
                if (checkForReadStart == true)
                {
                    if (line == "##")
                    {
                        startReading = true;
                        checkForReadStart = false;
                    }
                }
                //start reading once start position is found
                while (startReading == true)
                {
                    line = file.ReadLine();
                    if (line != null)
                    {
                        GameItem itemToAdd = new GameItem
                        {
                            name = line,
                            description = file.ReadLine(),
                            type = file.ReadLine(),
                            subType = file.ReadLine(),
                            attribute = Convert.ToInt32(file.ReadLine())
                        };
                        _currentItemList.Add(itemToAdd);
                    }
                    else
                    {
                        //stop reading once null is found
                        startReading = false;
                    }
                }


            }

            file.Close();

        }

        public GameItem getItem(string name)
        {
            foreach (GameItem gameItem in _currentItemList)
            {
                if (name == gameItem.name)
                {
                    return gameItem;
                }
            }
            //need to handle null case
            return null;
        }
    }
}
