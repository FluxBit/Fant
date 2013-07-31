﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Fant
{
    public partial class frmAbout : Form
    {
        String P1;
        String P2;
        public frmAbout()
        {
            InitializeComponent();
        }

        private void frmAbout_Load(object sender, EventArgs e)
        {
            P1 = "ПОРЯДОК ПРОВЕДЕНИЯ ИГРЫ\n"+
                "1. ПОДГОТОВКА РЕКВИЗИТОВ\n"+
                "1.1. Независимо от предполагаемого конечного результата Игры, начинайте ее с белых фантов, лишь постепенно переходя к «желтому», «розовому» и «красному» форматам.\n"+
                "1.2. Сформируйте колоды карт в зависимости от того, будет ли практиковаться во время Игры анальный секс, а так же использоваться те или иные аксессуары, особенно секс-игрушки.\n"+
                "Игра АБСЕНТ:\n"+
                "- если во время Игры не планируется использовать секс-игрушки, рекомендуется отложить розовые фанты № 43 - 50 и красные фанты № 29 - 50;\n"+
                "- если девушка не практикует анальный секс, заранее отложите красные фанты № 40 - 50.\n"+
                "Однако, поскольку разыгрывание большинства фантов не требует дополнительных аксессуаров, можно и не делать этого, а просто во время Игры откладывать некоторые задания в сторону.\n"+
                "2. ЖЕРЕБЬЕВКА\n"+
                "2.1. Перед вытаскиванием из колоды фанта каждый раз проводится жеребьевка. Цель жеребьевки заключается в определении игрока, которому предстоит вытянуть фант (фантующего). Фантующий всегда выполняет две задачи: вытягивает из колоды и зачитывает предстоящий к розыгрышу фант, а после окончания такого розыгрыша проводит новую жеребьевку, в процессе которой определяется следующий фантующий.\n"+
                "2.2. Игру начинает ее организатор (инициатор), который проводит первую жеребьевку.\n"+
                "2.3. Процедура жеребьевки заключатся в том, что проводящий ее игрок незаметно для партнера кладет в одну из ладоней фишку, а тот должен определить, в какой из рук она находится. Если угадал, то фантующим будет уже он, а если нет, то фантующий остается прежним.\n"+
                "3. ВЫПОЛНЕНИЕ ЗАДАНИЙ\n"+
                "3.1. После завершения жеребьевки фантующий, перемешав колоду с фантами, наугад вытягивает из колоды очередной разыгрываемый фант и зачитывает его. При этом фанты располагаются в колоде «рубашкой» вверх, так, чтобы не было видно цвет фанта и написанное на нем задание.\n"+
                "3.2. Сформулированное в фанте задание определяет выполняемые игроками роли. Оно может быть изложено исключительно в самом фанте, а может дополнительно сопровождаться ссылкой на позу из Каталога. В случае наличия в фанте дополнительной ссылки на позу, фантующий открывает такое изображение, наглядно поясняющее предстоящее к выполнению задание.\n" +
                "3.3. Участники выполняют сформулированное в фанте задание, играя указанные в нем роли.\n"+
                "3.4. Разыгранный (выполненный) фант откладывается и больше не используется в Игре.\n"+
                "3.5. Начинается новая жеребьевка и разыгрывается следующий фант.\n"+
                "3.6. В целях предоставления возможности «подстраховаться» в случае неуверенности, смущения или боязни, в порядок игры могут вводиться дополнительные подстраховки - «брейки». Порядок их применения описан в пункте 7 раздела 5.3 Правил Игры.\n"+
                "3.7. Версия игры АБСЕНТ включает в себя целый ряд длящихся заданий, т.е. заданий, выполняемых игроками в течение некоторого периода времени. В целях напоминания такие фанты можно закреплять, например, на холодильнике, с помощью входящего в реквизиты Игры магнита.";
            P2 = "ЦЕЛЬ ИГРЫ\n"+
                "Игра АБСЕНТ: предназначена для супругов или уже сложившихся пар, ведь привычки - главный враг близости, а однообразие убивает любовь. Поможет перевести отношения на принципиально иной уровень, взглянуть на возлюбленного с другой стороны, «подольет масла в огонь», внеся свежую струю в начавшую тускнеть интимную жизнь.\n"+
                "СУТЬ ИГРЫ\n"+
                "1. Игра заключается в выполнении участниками заданий, написанных на специальных карточках -фантах, вытягиваемых из колоды не глядя, вслепую. Задания выполняются игроками в соответствии с определяемыми жеребьевкой ролями.\n"+
                "2. Игра имеет четыре формата или уровня «жесткости»: «белый», «желтый», «розовый» и «красный». Соответственно и фанты бывают белыми, желтыми, розовыми и красными. «Белый» - самый «мягкий» и в основном сводится к рассказам, разговорам и воспоминаниям на эротические темы. При переходе по мере игры к следующим форматам задания становятся все более конкретными и реальными, заканчиваясь сексом в «красном» формате.\n"+
                "3 При переходе к «розовой» игре игроки вместе моются в ванне и это - первое розовое задание.\n"+
                "4. В принципе Игру не обязательно доводить до секса, а, ограничившись «мягкими» форматами, превратить ее в увлекательный розыгрыш эротической направленности.\n"+
                "ПОДГОТОВКА К ИГРЕ\n"+
                "1. Самым важным является психологический настрой на Игру каждого из ее участников. «Неудобно», «стыдно», «неприлично», - следует полностью забыть об этих понятиях, они не нужны прежде всего самому игроку. Раскованность, искренность и желание получить удовольствие без всяких условностей или опасений, - вот основные принципы Игры.\n"+
                "2. Весьма вероятно, что в процессе Игры вам придется целоваться, раздеваться и «стоять на голове». Учтите это: наденьте красивое нижнее белье, не ешьте плотно перед игрой, пожуйте «Орбит», воздержитесь от чеснока и поставьте клизмочку, если планируете анальный секс. Девушкам настоятельно рекомендуется одеваться к Игре, имея чулочки на поясе.\n"+
                "3. Создайте соответствующую атмосферу в месте проведения Игры, это во многом определит психологический настрой на нее. Особый интерьер, свечи, запахи, музыка... - все должно быть красиво, не стандартно и романтично.\n"+
                "4. Можно вполне успешно проводить Игру, ограничившись лишь теми реквизитами, которые прилагаются к ней. Однако «поле для творчества» можно существенно расширить, имея, хотя бы частично, следующие дополнительные аксессуары:\n"+
                "- бананы, яблоки, клубника, лимон, жидкий шоколад (сливки, джем, мед), ликер Бэйлис, Текила, вино, лед;\n"+
                "- массажное масло, специальные смазки, эротическое белье, беличья кисточка для макияжа;\n"+
                "- секс-игрушки (в зависимости от индивидуальных вкусов и возможностей): вибраторы (одинарный и двойной), клиторально-вагинальный вибратор, виброкольцо, фаллоимитаторы на присоске (одинарный и двойной), вагинальные виброшарики, страпон (фаллоимитатор на трусиках), анальные вибропробки, анальные бусы, анальный вибромассажер.";
            label1.Text = P1;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            label1.Text = P2;
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            label1.Text = P1;
        }
    }
}
