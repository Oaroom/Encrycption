using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decipher
{

    //암호화하는 클래스
    public class CEncrypt
    {
        //배열의 선언
        public char[] planeText;
        public char[,]keyTable;
        string key;
        string strEncry;


        public CEncrypt() {


            strEncry = "helloword";
            planeText = strEncry.ToCharArray();

        }


        public CEncrypt(string strEncry) {

            strEncry = "helloword";
            planeText = strEncry.ToCharArray();

        }

        public int Initialize() {

            keyTable = new char[5,5];


            return (1);

        }


        //평문을 받아 key 값을 만들기
        public string setKey() {
            
            int cnt=0;
            
            //중복값 제거
            for (int i = 0; i < planeText.Length; i++) {

                for (int j = 0; j < planeText.Length; j++) {

                    if (planeText[i] == planeText[j] && i != j) {

                        planeText[j] = ' ';

                    }

                }

            }

            key = (new string(planeText).Replace(" ",""));
            
            return (key);

        }


        //테이블 세팅하기
        public string setTable() {

            

            for (char c = key[key.Length-1]; c <= 'z' || c <= 'Z'; c++) {

                for (int i = 0; i < key.Length; i++) {

                    if (key[i] == c) { ++c; }

                }
                
                key += c;

            }

            //배열에 넣기
            /*
            int k = 0;
            for (int i = 0; i < 5; i++) {

                for (int j=0; j < 5; j++,k++) {

                    keyTable[i, j] = key[k];

                }

            }
            */

            return (key);

        }
    }
}
