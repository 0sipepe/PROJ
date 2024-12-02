﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TsvetovoyKod
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            rtbInstruction.Text = "1. Зарегистрируйтесь (введите имя в окошко) - так ваши результаты сохранятся. Можно не вводить имя, однако, так ваши результаты не сохранятся. \n" +
                "2. Нажмите \"начать уровни\".Откроются два окна. В правом окне появится картинка. Вам нужно максимально точно перерисовать картинку с помощью окна слева. \n" +
                "3. У окна слева есть два режима - режим рисовния и режим редактирования. За это отвечает кнопка \"режим\".  Чтобы рисовать, кликните мышкой по левому окну. \n" +
                "4. Редактировать можно двумя методами - двигать и растягивать. Чтобы двигать, поместите курсор внутрь фигуры и кликните мышкой. Чтобы растянуть фигуру, поместите курсор мыши на нижней грани фигуры или же на правой грани фигуры и кликните мышкой. \n" +
                "5. Кнопка \"удалить\" работает по-разному в зависимости от режимов - в режиме рисования она очищает весь холст, а в режиме редактиования - только фигуру, которую вы выделили" + 
                "6. Кнопка \"назад\" в режиме рисования удаляет последнюю нарисованную фигуру, а в режиме редактирования - отменяет последнее изменение" +
                "7. При нажатии кнпоки \"проверить результат\" выплывет сообщение с процентами (!!!) совпадения Вашего рисунка с рисунком-заданием. \n" +
                "8. Меняйте уровни кнопками внизу справа. \n" +
                "9. Вы можете в любое время вернуться в главное меню, однако, уровень придется начать заново. \n" +
                "10. Чтобы посмотреть доску лидеров, нажмите на соответствующую кнопку в главном меню \n" +
                "приятной игры!";

            btnBackFromInstruct.BackColor = Color.Plum;
            btnBackFromInstruct.ForeColor = Color.Black;
           


        }

        private void btnBackFromInstruct_Click(object sender, EventArgs e) =>  this.Visible = false;
        

        
    }
}
