using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Localization : MonoBehaviour
{
    private class English
    {
        public void SetLanguage()
        {

        }
    }

    private class Russian
    {
        public void SetLanguage()
        {
            
        }
    }

    [SerializeField] private Canvases _canvases;
    [SerializeField] private Data _data;

    private void Awake()
    {
        // SetLanguage(Application.systemLanguage.ToString());
    }

    private void SetLanguage(string language)
    {
        switch (language)
        {
            case "Russian":
            case "Belarusian":
            case "Ukrainian":
                SetRussianLanguage();
                break;
            default:
                SetEnglishLanguage();
                break;    
        }
    }

    public void SetRussianLanguage()
    {
        #region Menu
        #region Main Menu
        _canvases.MenuCanvas.MainMenuCanvas.NameOfTheGame.text = "БУНКЕР";
        _canvases.MenuCanvas.MainMenuCanvas.Username.placeholder.GetComponent<TMP_Text>().text = "Имя пользователя...";
        _canvases.MenuCanvas.MainMenuCanvas.RoomName.placeholder.GetComponent<TMP_Text>().text = "Название комнаты...";
        _canvases.MenuCanvas.MainMenuCanvas.ButtonPlay.GetComponentInChildren<TMP_Text>().text = "Играть";
        _canvases.MenuCanvas.MainMenuCanvas.ConnectToServer.text = "Подключение к серверу";
        _canvases.MenuCanvas.MainMenuCanvas.RulesOfTheGame.text = "Правила игры";
        _canvases.MenuCanvas.MainMenuCanvas.WordField = "Поле";
        _canvases.MenuCanvas.MainMenuCanvas.WordEmpty = "пустое";
        #endregion
        #region Settings
        #endregion
        #region Information 
        _canvases.MenuCanvas.InformationCanvas.Title.text = "ПРАВИЛА ИГРЫ «БУНКЕР»";
        _canvases.MenuCanvas.InformationCanvas.Subtitle.text = "«БУНКЕР» - ЭТО ДИСКУССИОННАЯ КАРТОЧНАЯ ИГРА С ПОСТАПОКАЛИПТИЧЕСКИМ СЮЖЕТОМ.";
        _canvases.MenuCanvas.InformationCanvas.PlotTitle.text = "СЮЖЕТ:";
        _canvases.MenuCanvas.InformationCanvas.PlotDescription.text = "На земле произошла катастрофа. Часть людей находится возле спасительного бункера, и каждый мечтает попасть в него и выжить. Но количество спасительных мест ограничено: в бункер попадёт только половина, остальные останутся в лесу.\n\n" +
            "Каждый круг проходит голосование, по которому участники решают, кто из людей попадает в бункер. Финалисты будут возрождать быт и население Земли.\n\n" + 
            "Игроки должны выбрать самых полезных людей для восстановления жизни на постапокалиптической планете. Именно они попадут в бункер.\n\n" + 
            "У каждого персонажа есть набор характеристик: профессия, здоровье, биологические характеристики, хобби, фобии, дополнительные навыки, человеческие качества.По ним участники оценивают персонажа, насколько он будет полезен после выхода из бункера. Оружия и насилия нет, только дискуссия и обоснование своей важности и необходимости.";
        _canvases.MenuCanvas.InformationCanvas.PurposeOfTheGameTitle.text = "ЦЕЛЬ ИГРЫ:";
        _canvases.MenuCanvas.InformationCanvas.PurposeOfTheGameDescription.text = "Собрать вместе группу людей, которая сможет обеспечить друг другу выживание.";
        _canvases.MenuCanvas.InformationCanvas.RulesOfTheGameTitle.text = "ПРАВИЛА ИГРЫ:";
        _canvases.MenuCanvas.InformationCanvas.RulesOfTheGameDescription.text = "От 3 - 16 игроков\n\n" +
            "Каждому игроку предстоит сыграть роль персонажа со случайными характеристиками, такими как профессия, здоровье, пол, возраст, сексуальная орентация, хобби, умения, характер, багаж. Также каждый игрок получит карту действия и знания, которые можно использовать в свою пользу в любой момент.\n\n" +
            "В первом раунде каждый игрок должен открыть профессию своего персонажа. В каждом следующем раунде игроки открывают любую свою характеристуку в целях доказательства своей полезности в бункере. В конце каждого раунда, начиная со второго, происходит голосование за самого бесполезного игрока, который впоследствии выбывает из соревнования за место в бункере и больше не может участвовать в обсуждении и голосовании. Игра заканчивается, когда игроков останется столько же сколько мест в бункере.";
        #endregion
        #region About
        #endregion       
        #endregion

        #region Game
        #region Description Canvas
        _canvases.GameCanvas.DescriptionCanvas.Desciption.text = "ОПИСАНИЕ";
        _canvases.GameCanvas.DescriptionCanvas.WordBunker = "Бункер";
        _canvases.GameCanvas.DescriptionCanvas.WordArea = "Площадь";
        _canvases.GameCanvas.DescriptionCanvas.WordTimeSpent = "Время нахождения";
        _canvases.GameCanvas.DescriptionCanvas.WordFoodSupplies = "Запасы еды на";
        _canvases.GameCanvas.DescriptionCanvas.WordLocation = "Расположение";
        _canvases.GameCanvas.DescriptionCanvas.WordResources = "Ресурсы";
        _canvases.GameCanvas.DescriptionCanvas.WordPremises = "Помещения";
        _canvases.GameCanvas.DescriptionCanvas.WordYear = "год";
        _canvases.GameCanvas.DescriptionCanvas.WordYears = "года";
        _canvases.GameCanvas.DescriptionCanvas.WordYearsForRussian = "лет";
        _canvases.GameCanvas.DescriptionCanvas.WordMonth = "месяц";
        _canvases.GameCanvas.DescriptionCanvas.WordMonths = "месяца";
        _canvases.GameCanvas.DescriptionCanvas.WordMonthsForRussian = "месяцев";
        _canvases.GameCanvas.DescriptionCanvas.WordNumberPlaces = "Количество мест";
        #endregion
        #region User Canvas
        #endregion
        #region Users Canvas
        _canvases.GameCanvas.UsersCanvas.Users.text = "ИГРОКИ";
        #endregion
        #endregion

        _canvases.GameCanvas.UserCanvas.TranslateKeywords = new Dictionary<string, string>
        {
            {  Keys.Profession, "Профессия" },
            {  Keys.Skills, "Способность" },
            {  Keys.Sex, "Пол" },
            {  Keys.Age, "Возраст" },
            {  Keys.SexualOrientation, "Сексуальная орентация" },
            {  Keys.Health, "Здоровье" },
            {  Keys.Hobby, "Хобби" },
            {  Keys.CharacterTraits, "Черты характера" },
            {  Keys.Phobia, "Фобия" },
            {  Keys.Additionally, "Дополнительно" },
            {  Keys.SmallLuggage, "Малый багаж" },
            {  Keys.BigLuggage, "Большой багаж" },

        };

        _data.SetData = new Dictionary<string, DataParams>
        {
            {
                "Profession", new DataParams
                {
                    Text = new List<string>
                    {
                        "Абитуриент", "Автомеханик" , "Агроном", "Адвокат", "Актер / Актриса",
                        "Бармен", "Бизнесмен", "Ботаник", "Букмекер", "Бурильщик", "Бухгалтер", "Вахтер", "Ветеринар",
                        "Винодел", "Мирон", "Вирусолог", "Военнослужащий", "Вор", "Проститука", "Геймер", "Генетик", "Географ", "Горничная",
                        "Дальнобойщик", "Дегустатор", "Дипломат", "Доктор", "Доярка", "Жокей", "Изобретатель", "Инженер", "Кальянщик", "Кинорежиссер",
                        "Клоун", "Коллектор", "Лейтенант", "Мясник", "Наркобарон", "Онколог", "Пивовар", "Повар", "Порно актер", "Программист",
                        "Прораб", "Стример", "Строитель", "Судья", "Сушист","Тракторист", "Фармацевт", "Хакер", "Экономист", "Юрист", "Никита",
                        
                        "Профессиональный стоящий в очереди", "Дегустатор корма для животных", "Дегустатор мороженого", "Профессиональный обниматель", "Подружка невесты",
                        "Актер озвучивания", "Смотритель панд", "Психолог для животных", "Переворачиватель пингвинов", "Туалетный гид", "Тестер проституток", "Нюхатель подмышек"
                        
                    }
                }
            },
            {
                "Skills", new DataParams
                {
                    Skill = new List<Skill>
                    {
                         new Skill { FirstSkill = "Может поменять свою профессию на случайную, если он не младше 18 или старше 27 лет. В противном случае становится Солдатом.", SecondSkill = "Может прожить без еды две недели."},
                         new Skill { FirstSkill = "Знает, где находится СТО.",  },
                         new Skill { FirstSkill = "Добавляет себе в инвентарь ящик с продуктами.",  },
                         new Skill { FirstSkill = "Один раз за игру может перенаправить голос на себя, который был против какого-то игрока.",  },
                         new Skill { FirstSkill = "Может использовать возможность профессии любого игрока.",  },
                         new Skill { FirstSkill = "Один раз за игру может добавить состояние здоровья “Алкоголизм (легкая степень)” любому игроку.",  },
                         new Skill { FirstSkill = "Может забрать себе открытый инвентарь изгнанного игрока.",  },
                         new Skill { FirstSkill = "Добавляет себе в инвентарь семена любых растений.",  },
                         new Skill { FirstSkill = "Может обменять местами хобби двух игроков.",  },
                         new Skill { FirstSkill = "Добавляет себе в инвентарь дрель с полной зарядкой (зарядки хватит на 24 часа активных работ).",  },
                         new Skill { FirstSkill = "Может изменить количество еды в бункере с \"в недостатке\" на \"в избытке\" и наоборот.",  },
                         new Skill { FirstSkill = "Добавляет себе в инвентарь сейф.",  },
                         new Skill { FirstSkill = "Добавляет в инвентарь любое животное (до 50 кг.)",  },
                         new Skill { FirstSkill = "При попадании в бункер пронесет с собой ящик с вином.",  },
                         new Skill { FirstSkill = "Один раз за игру может узнать всю информацию о любом человеке",  },
                         new Skill { FirstSkill = "Добавляет в инвентарь универсальную вакцину (1 шт.) от воздушно-капельных инфекций.",  },
                         new Skill { FirstSkill = "Добавляет в инвентарь пистолет и 28 пуль",  },
                         new Skill { FirstSkill = "Может украсть инвентарь у другого игрока.",  },
                         new Skill { FirstSkill = "Может один раз за игру излечить любого",  },
                         new Skill { FirstSkill = "Прошёл все игры по выживанию и знает парочку ценных советов, как выжить в экстремальной ситуации.",  },
                         new Skill { FirstSkill = "При попадании в бункер значительно поднимает шанс на рождение здоровых детей.",  },
                         new Skill { FirstSkill = "Добавляет себе в инвентарь карту местности.",  },
                         new Skill { FirstSkill = "Добавляет себе в инвентарь набор для дезинфекции.",  },
                         new Skill { FirstSkill = "Добавляет себе в инвентарь стопку порножурналов.",  },
                         new Skill { FirstSkill = "Неуязвим к фобиям и болезням, связанным с алкоголем. Добавляет себе в инвентарь 10 л. любого напитка.",  },
                         new Skill { FirstSkill = "По желанию может отменить действие карты друга или врага, если такая на него направлена.",  },
                         new Skill { FirstSkill = "Один раз за игру может вылечить любую болезнь, степень которой \"легкая\" или \"средняя\" любому игроку, кроме себя.",  },
                         new Skill { FirstSkill = "Добавляет себе в инвентарь корову.",  },
                         new Skill { FirstSkill = "Добавляет себе в инвентарь лошадь.",  },
                         new Skill { FirstSkill = "При попадании в бункер в инвентаре появляется автоматический инкубатор для яиц.",  },
                         new Skill { FirstSkill = "При попадании в бункер сможет создать в бункере оборудованную теплицу для выращивания растений.",  },
                         new Skill { FirstSkill = "При прохождении в бункер добавляет оборудованную кальянную комнату. Размер бункера при этом не меняется.",  },
                         new Skill { FirstSkill = "Может перегенерировать всем игрокам характеристику \"Доп. сведения\".",  },
                         new Skill { FirstSkill = "Может сменить специальности по часовой стрелке. Работает 1 раз за игру.",  },
                         new Skill { FirstSkill = "Может украсть инвентарь у любого игрока.",  },
                         new Skill { FirstSkill = "При голосовании может удалить 1 голос против себя."},
                         new Skill { FirstSkill = "Добавляет себе в инвентарь 5кг сырокопченного мяса."},
                         new Skill { FirstSkill = "Добавляет в инвентарь любому игроку 2 пакетика (по 100 г.) с теми самыми травами от депрессии."},
                         new Skill { FirstSkill = "Может уменьшить степень болезни онкологических заболеваний до “Легкая степень” (один раз за игру).\n* Нельзя применить для игрока у которого степень болезни \"Критическая\".\n* Вылечить болезнь невозможно."},
                         new Skill { FirstSkill = "Добавляет себе в инвентарь пиво 0.5 л (1 ящик) и семена хмеля."},
                         new Skill { FirstSkill = "Добавляет 10 уп. доширака в свой инвентарь."},
                         new Skill { FirstSkill = "Имеет возможность вылечить чайлдфри у противоположного пола."},
                         new Skill { FirstSkill = "Может перегенерировать специальность любого игрока, кроме себя."},
                         new Skill { FirstSkill = "Может разделить любую комнату в бункере на 2 комнаты."},
                         new Skill { FirstSkill = "Может открыть дополнительную характеристику на своем ходу (один раз за игру)."},
                         new Skill { FirstSkill = "Добавляет в бункер любую комнату. Размер бункера не меняется."},
                         new Skill { FirstSkill = "Если при голосовании игроки получили равное количество голосов - может решить кого выгнать. Решение можно принять один раз за игру."},
                         new Skill { FirstSkill = "Добавляет 2 кг суши в инвентарь."},
                         new Skill { FirstSkill = "Может сказать \"300\" и получить в инвентарь 2 кг зерна."},
                         new Skill { FirstSkill = "Знает, где находится склад с медикаментами."},
                         new Skill { FirstSkill = "Добавляет себе в инвентарь ноутбук с зарядным устройством."},
                         new Skill { FirstSkill = "Способен рассчитать количество еды таким образом, что его хватит на ещё 1 месяц."},
                         new Skill { FirstSkill = "Может решить (вне зависимости от мнения других игроков) стоит ли проголосовать в раунде или пропустить голосование."},
                         new Skill { FirstSkill = "Игрок превращается в медведя и убивает одного игрока (на выбор)"},

                         new Skill { FirstSkill = ""},
                    }
                }
            },
            {
                "SecondSkill", new DataParams
                {
                    Text = new List<string>
                    {
                        "Добавляет одно место в бункер", "Позволяет вылечить от любого недуга любого игрока кроме вас", "Игрок напротив тебя не должен попасть в бункер", "Убирает из бункера змей", "Защищает любого игрока на один ход (кроме вас)",
                        "Возле бункера находится склад с оружием", "Любой игрок по выбору раскрывает свое хобби", "Позволяет обучится хобби другого игрока", "Игрок слева от тебя должен попасть в бункер", "Бункер находится в лесу",
                        "Возле вас находится бункер с двумя женщинами-химиками (Полностью здоровые / возраст: 25-45 лет)", "Позволяет обменяться фобиями с другим игроком", "Возле бункера находится танк", "Убирает из бункера пауков",
                        "Позволяет активировать карту№2 игрока по выбору", "добавляет в бункер пауков", "Все узнают что бункер находится на необитаемом острове",
                        "Обмен профессиями слева направо", "Возле вас находится бункер с агрессивно настроенными выжившими", "Можешь поменяться здоровьем с другим игроком",
                        "Можешь поменяться профессией с другим игроком", "Убирает место из бункера", "Возле вас находится бункер со всеми актрисами браззерс(Полностью здоровые/возраст: 20-45 лет);"
                    }
                }
            },
            {
                "Sex", new DataParams
                {
                    Text = new List<string>
                    {
                        "Мужчина", "Женщина"
                    }
                }
            },
            {
                "Age", new DataParams
                {

                }
            },
            {
                "SexualOrientation", new DataParams
                {
                    Text = new List<string>
                    {
                        "Гетеросексуал", "Гей", "Лесбиянка", "Бисексуал", "Квир (странный)", "Асексуал", "Аромантик", "Андросексуал", "Гиносексуал", "Демисексуал", "Пансексуал", "Трансвестит"
                    }
                }
            },
            {
                "Health", new DataParams
                {
                    Text = new List<string>
                    {
                        "Идеально здоров", $"Краб {Random.Range(1, 5)} степени", "Наркоман Павлик", "Один глаз на кавказ, другой в арзамас (косоглазие)", "Туберкулёз", "Изжога", "Бешенство", "Дальтоник", "Сколиоз",
                        "Шизик", "Гепатит Б", "ВИЧ", "Covid-19", "Делирий", "Психоз", "Плоскостопие", "Синдром хрустального человека", "Рахит", "Булимия", $"Спид (Умрёт через {Random.Range(2, 4)} года", "В целом здоров",
                        "Геморой", "Альгеймер", "Рак Груди", "Алкоголизм легкой степени", "Рак Крови (умрет через год)", "Диабет", "Прыщи", "Безногий", "Безрукий", "Немой", "", "Паранойя"
                    }
                }
            },
            {
                "Hobby", new DataParams
                {
                    Text = new List<string>
                    {
                        "Коллекционирует жуков и пауков", "Проводит время с птичками", "Трейнсерфинг", "Собирать ключ-кольцо от банок пива", "Взламывать терминалы", "Танцы", "Военные игры", "Картография", "Готовка", "Стрелять из оружия",
                        "Фотограф", "Пить пиво", "Прыжки без парошюта", "Скалолазание", "Стритлюж", "Заезд на мотоцикле", "Пропускать пары", "Мыловарение", "Создание оружия", "Бодибилдинг и тяжелая атлетика",
                        "Выращивание растений", "Пивоварение", "Сыроварение", "Чаепитие", "Кушать мухаморы", "Искать закладку", "Подрабатывать таксистом (у меня свой бизнес)", "Пикапить", "Стрельба из лука", "Бокс", "Разводить животных",
                        "Программирование", "Участие в благотворительных и общественно значимых проектах", "Cадоводство", "мастурбация", "Боевые искусства", "Исторические реконструкции", "Карточные игры", "Теннис", "Конструирование зданий"
                    }
                }
            },
            {
                "CharacterTraits", new DataParams
                {
                    Text = new List<string>
                    {
                        "Доброта", "Честность", "Верность", "Отзывчивость", "Щедрость", "Юмор", "Аккуратность", "Бестрашие", "Активный", "Мудрый", "Выдержка", "Наблюдательный", "Оптимист", "Удачливость", "Отзывчивость",
                        "Романтичный", "Настойчивый", "Пунктуальность", "Собранность", "Спокойствие", "Трудолюбие", "Чувство долга", "Энтузиазм", "Элегантность", "Хозяйственность", "Усидчивость", "Упорство", "Открытость", "Общительность",
                        "Вредность", "Ворчливость", "Замкнутость", "Лень", "Лицемерие", "Необщительность", "Настойчивость", "Мужество", "Мудрость", "Эгоизм", "Раздражение", "Пассивность", "Жадность", "Терпимость", "Спокойствие"
                    }
                }
            },
            {
                "Phobia", new DataParams
                {
                    Text = new List<string>()
                    {
                        "Нету", "Селахофобия – боязнь акул", "Нозофобия – боязнь болезней", "Алгофобия – боязнь боли", "Бронтофобия – боязнь грома", "Рипофобия – боязнь грязи", "Клаустрофобия", "Эйсоптрофобия – боязнь зеркала", "Офидиофобия – боязнь змей",
                        "Арахнофобия – боязнь пауков", "Танатофобия – боязнь смерти", "Ахлуофобия – боязнь темноты", "Аэтатемофобия – боязнь старения", "Карциноматофобия – боязнь рака", "Скелерофобия – боязнь плохих людей",
                        "катагелофобия – боязнь насмешек", "Айхмофобия – острых предметов", "Дисморфофобия – боязнь физических недостатков", "Аквафобия – боязнь утопления", "Трипанофобия – боязнь уколов", "Пнигофобия – боязнь удушения",
                        "Некрофобия – боязнь трупов", "Ятрофобия – боязнь врачей", "Акрофобия – боязнь высоты", "Глоссофобия – боязнь выступления на публике", "Социофобия", "Пирофобия – боязнь огня",
                        "Эремофобия – боязнь одиночества", "Катагелофобия – боязнь насмешек", "Спермофобия – боязнь микробов", "Дентофобия – боязнь зубных врачей", "Гематофобия – боязнь крови", "Родентофобия – боязнь крыс",
                        "Гравидофобия — боязнь встречи с беременной беременности"
                    }
                }
            },
            {
                "Additionally", new DataParams
                {
                    Text = new List<string>
                    {
                        "Аккуратность", "хорошо занет высшую математику", "Еврей", "Негр", "Получил удар лещом", "Имеет экстрасенсорные способности", "Знает где находятся припасы семян на один гектар",
                        "Знает где находятся припасы еды на два месяца", "Основатель ЧБД", "Хорошо ладит с животными", "Инвалид", "Умеет жонглировать", "Проходил(а) курсы парикмахера",
                        "Ненавидит современную музыку", "Пережил(а) три покушения", "Обладает феноменальной памятью", "Лоуреат Нобелевской премии", "Нету", "Пристаёт к мужчинам", "Коммунист", "Знает своё имя",
                        "Умеет дышать", "Умеет пользоваться ручкой", "Умеет открывать консервы", "Эта катастрофа заговор рептилий", "Верит в инопланетян", "Шизик", "Верит в Бога", "Верит в Дьявола", "Увлекается охотой",
                        "Читал(а) книгу про выживание на необитаемом острове", "Страдает морской болезнью", "Проектировал(а) этот бункер", "Может может оказать первую помощь", "Продил(а) курсы кулинарии", "Копрофил",
                        "Основатель голубая луна", "Владеет антикафе", "Может зажечь сырые дрова", "Сбежал из тюрьмы", "Победил во всех школьных квестах", "Дружит с тимати. Хлопнул бургер за здоровье собянина", "Эксперт по выживанию",
                        "Рекламировал Партию ЛДПР", "Умеет готовить жуков", "Имеет 4 млн подписчиков в инстаграме", "Однажды перепил синего лорда", "Делает вкусные дранники"
                    }
                }
            },
            {
                "SmallLuggage", new DataParams
                {
                    Text = new List<string>
                    {
                        "Перья", "Бинты", "Пинцент", "Телефон", "Набор посуды", "Пистолет", "Годовой запас макарона", "Часы", "Пустая картонная коробка", "Мыло", "Верёвка", "Дубинка", "Фонарик и запасные батарейки",
                        "Набор кухонный инструментов", "Вибратор", "Камера безопастности", $"Порно журналы ({Random.Range(1, 8)} шт)", "Ручка", "Азбука", "Беспроводная колонка", "Губная гормошка", "Жвачка (мятная)",
                        $"Тест полоски ({Random.Range(1, 4)} шт)", "Станки для бриться", "Бутылка для воды (5л)", "Зеркало", "Капканы", "Еды на одну неделю", "Пинцет", "Будильник", "Книга по маникюру", "Грузинский чай", "Индийский чай",
                        "Четыре рации", "Игла и нитки", "Флаг США", "Огниво", "Батарейка", "Рюкзак", "Компас", "Чугунная посуда", "Использованный шприц", "Фотография земли с космоса", "Презервативы",
                        "Паук", "Черепаха", "Игрушки", "Лом", "Лопата", "Граната", "Чемодан", "Покер", "Джостик", "Паспорт", "Книга с азбукой морзе", "Персийский кот", "Патроны для пистолета (24 шт)", "Две банки пива",
                        "Бутылка водки", "Десять одноразовых медицинский масок", "Красный диплом", "Телефон", "Семеня картофеля", "Молоток и гвозди", "Железная труба", "Солнезащитные очки", "Колько с бриллиантом",
                        "Набор инструментов", "Почка"

                    }
                }
            },
            {
                "BigLuggage", new DataParams
                {
                    Text = new List<string>
                    {
                        "Годовой запас макарона", "Огнетушитель", "Двигатель", "Генератор", "Корова с едой на 3 месяца", "Велосипед", "Топор", "Рулон туалетной бумаги (100 м)", "Набор фельдшера скорой помощи",
                        "Конструктор лего машинки на 521 детали", "Настольные игры (3 шт)", "Автомат с 3-я рожками", "Костюм РЗК (2 шт)", "Костюм для ролевых игр", "Строительный набор", "Радиостация", "Немецкая овчарка",
                        "Еды на один месяц", "Телевизор", "Спальные мешки", "Чертила", "Окно", "Операционный набор", "Упаковка освежителей воздуха", "Кассовый аппарат", "Упаковка белой бумаги А4",
                        "Холодильник", "Туалет", "Гроб", "Батут", "Дверь", "Колесо от Белаза", "Пингвин", "С4", "Пылесос", "Газонокосилка", "Трактор", "Стул с пиками точёными", "Две коровы", "Хорёк", "Кот", "Собака"
                    }
                }
            },
            {
                "BunkerName", new DataParams
                {
                    Text = new List<string>
                    {
                        "77", "Немо", "Альфа", "1771", "Об. 99", "Ленгов", "Армата", "ВВО", "АТУБ", "Гинтор", "Невс", "Бета", "Гамма", "Дельта", "Ламбда", "Ранний 997", "Вервольф",
                    }
                }
            },
            {
                "BunkerPlace", new DataParams
                {
                    Text = new List<string>
                    {
                        "Пустыня", "Заповедник", "Лес", "Необитаемый остров", "Город", "Тропики", "Горная местность", "Деревня", "Трущобы", "Поле", "Тундра", "Байкал", "Пуща", "Болотная местность", "Планктация", "Вервольф",
                    }
                }
            },
            {
                "BunkerArea", new DataParams
                {
                    Text = new List<string>
                    {
                        "47", "100", "89", "55", "170", "139", "350", "320", "120", "80", "300", "187", "145", "200", "250", "240", "129", "192", "77", "215"
                    }
                }
            },
            {
                "BunkerResources", new DataParams
                {
                    Text = new List<string>
                    {
                        "Аптечка", "Зимняя одежда", "Набор первой помощи", "Инструкция по выживанию в лесу", "Радио;", "Набор инструментов", "Барабаны", "Мягкие игрушки", "Аптечка первой помощи",
                        "Самогонный аппарат", "Сломанный генератор", "Генератор с бензином", "Набор сухпайков", "Набор томатных супов", "Запас воды", "Шашки", "Шахматы", "Фонарик", "Топор",
                        "Игральные карты", $"Ружьё с обоймой на {Random.Range(1, 9)} шт. патрон", "Бонг", "Чемодан с одеждой", "Фонарик", "Карта местности", "Крысинный яд", "Туба", "Гитара", "Аптечка",
                        "Снюс", "Баян", "Настольная лампа", "Косметичка", "Учебное пособие как выжить в бункере", "Зимняя одежда", "Гидрокостюм c баллоном воздуха"
                    }
                }
            },
            {
                "BunkerBuildings", new DataParams
                {
                    Text = new List<string>
                    {
                        "Теплица", "Сломанная теплица", "Офисный кабинет", "Столовая", "Хим. лабаратория", "Склад с провизией", "Лабаратория для исследований", "Парикмахерская", "Пустой склад", "Душевая комната",
                        "Генератор с бензином", "Мастерская с инструментами", "Медкабинет", "Радиостанция", "Спортзал", "Актовый зал (со сценой)", "Помещение с токарным станком",
                        "Лаборатория для варки мета", "Склад с оружием", "Подвал", "Комната полная хентай комиксов", "Подготовленная операционная", "Самогонный аппарат", "Кабинет информационных технологий",
                        "Замаскированная труба для наблюдения за поверхностью", "Уничтоженный медицинский кабинет", "Завалленн оружейня", "Несколько спальный комнат", "Сломанная хим. лабаратория", "Оранжерея",
                        "Уничтоженная оранжерея", "Заваленная оранжерея", $"Заваленная спальная комната с {Random.Range(1, 7)} шт. кровать", "Пустая комната"
                    }
                }
            }
        };
    }

    public void SetEnglishLanguage()
    {
        #region Menu
        #region Main Menu
        _canvases.MenuCanvas.MainMenuCanvas.NameOfTheGame.text = "BUNKER";
        _canvases.MenuCanvas.MainMenuCanvas.Username.placeholder.GetComponent<TMP_Text>().text = "Usernamer...";
        _canvases.MenuCanvas.MainMenuCanvas.RoomName.placeholder.GetComponent<TMP_Text>().text = "Room name...";
        _canvases.MenuCanvas.MainMenuCanvas.ButtonPlay.GetComponentInChildren<TMP_Text>().text = "Play";
        _canvases.MenuCanvas.MainMenuCanvas.ConnectToServer.text = "Connect to server";
        _canvases.MenuCanvas.MainMenuCanvas.RulesOfTheGame.text = "Rules of the game";
        _canvases.MenuCanvas.MainMenuCanvas.WordField = "Field";
        _canvases.MenuCanvas.MainMenuCanvas.WordEmpty = "empty";
        #endregion
        #region Settings
        #endregion
        #region Information 
        _canvases.MenuCanvas.InformationCanvas.Title.text = "ПРАВИЛА ИГРЫ «БУНКЕР»";
        _canvases.MenuCanvas.InformationCanvas.Subtitle.text = "«БУНКЕР» - ЭТО ДИСКУССИОННАЯ КАРТОЧНАЯ ИГРА С ПОСТАПОКАЛИПТИЧЕСКИМ СЮЖЕТОМ.";
        _canvases.MenuCanvas.InformationCanvas.PlotTitle.text = "СЮЖЕТ:";
        _canvases.MenuCanvas.InformationCanvas.PlotDescription.text = "На земле произошла катастрофа. Часть людей находится возле спасительного бункера, и каждый мечтает попасть в него и выжить. Но количество спасительных мест ограничено: в бункер попадёт только половина, остальные останутся в лесу.\n\n" +
            "Каждый круг проходит голосование, по которому участники решают, кто из людей попадает в бункер. Финалисты будут возрождать быт и население Земли.\n\n" +
            "Игроки должны выбрать самых полезных людей для восстановления жизни на постапокалиптической планете. Именно они попадут в бункер.\n\n" +
            "У каждого персонажа есть набор характеристик: профессия, здоровье, биологические характеристики, хобби, фобии, дополнительные навыки, человеческие качества.По ним участники оценивают персонажа, насколько он будет полезен после выхода из бункера. Оружия и насилия нет, только дискуссия и обоснование своей важности и необходимости.";
        _canvases.MenuCanvas.InformationCanvas.PurposeOfTheGameTitle.text = "ЦЕЛЬ ИГРЫ:";
        _canvases.MenuCanvas.InformationCanvas.PurposeOfTheGameDescription.text = "Собрать вместе группу людей, которая сможет обеспечить друг другу выживание.";
        _canvases.MenuCanvas.InformationCanvas.RulesOfTheGameTitle.text = "ПРАВИЛА ИГРЫ:";
        _canvases.MenuCanvas.InformationCanvas.RulesOfTheGameDescription.text = "От 3 - 16 игроков\n\n" +
            "Каждому игроку предстоит сыграть роль персонажа со случайными характеристиками, такими как профессия, здоровье, пол, возраст, сексуальная орентация, хобби, умения, характер, багаж. Также каждый игрок получит карту действия и знания, которые можно использовать в свою пользу в любой момент.\n\n" +
            "В первом раунде каждый игрок должен открыть профессию своего персонажа. В каждом следующем раунде игроки открывают любую свою характеристуку в целях доказательства своей полезности в бункере. В конце каждого раунда, начиная со второго, происходит голосование за самого бесполезного игрока, который впоследствии выбывает из соревнования за место в бункере и больше не может участвовать в обсуждении и голосовании. Игра заканчивается, когда игроков останется столько же сколько мест в бункере.";
        #endregion
        #region About
        #endregion
        #endregion

        #region Game
        #region Description Canvas
        _canvases.GameCanvas.DescriptionCanvas.Desciption.text = "DESCRIPTION";
        _canvases.GameCanvas.DescriptionCanvas.WordBunker = "Bunker";
        _canvases.GameCanvas.DescriptionCanvas.WordArea = "Area";
        _canvases.GameCanvas.DescriptionCanvas.WordTimeSpent = "Residence period";
        _canvases.GameCanvas.DescriptionCanvas.WordFoodSupplies = "Food stocks for";
        _canvases.GameCanvas.DescriptionCanvas.WordLocation = "Location ";
        _canvases.GameCanvas.DescriptionCanvas.WordResources = "Resources";
        _canvases.GameCanvas.DescriptionCanvas.WordPremises = "Premises";
        _canvases.GameCanvas.DescriptionCanvas.WordYear = "year";
        _canvases.GameCanvas.DescriptionCanvas.WordYears = "years";
        _canvases.GameCanvas.DescriptionCanvas.WordYearsForRussian = null;
        _canvases.GameCanvas.DescriptionCanvas.WordMonth = "month";
        _canvases.GameCanvas.DescriptionCanvas.WordMonths = "months";
        _canvases.GameCanvas.DescriptionCanvas.WordMonthsForRussian = null;
        _canvases.GameCanvas.DescriptionCanvas.WordNumberPlaces = "Number of seats";
        #endregion
        #region User Canvas
        #endregion
        #region Users Canvas
        _canvases.GameCanvas.UsersCanvas.Users.text = "PLAYERS";
        #endregion
        #endregion

        _canvases.GameCanvas.UserCanvas.TranslateKeywords = new Dictionary<string, string>
        {
            {  Keys.Profession, "Profession" },
            {  Keys.Skills, "Skill" },
            {  Keys.Sex, "Sex" },
            {  Keys.Age, "ВозрAgeаст" },
            {  Keys.SexualOrientation, "Sexual orientation" },
            {  Keys.Health, "Health" },
            {  Keys.Hobby, "Hobby" },
            {  Keys.CharacterTraits, "Character traits" },
            {  Keys.Phobia, "Phobia" },
            {  Keys.Additionally, "Additionally" },
            {  Keys.SmallLuggage, "Small luggage" },
            {  Keys.BigLuggage, "Big luggage" },

        };

        _data.SetData = new Dictionary<string, DataParams>
        {
            {
                "Profession", new DataParams
                {
                    Text = new List<string>
                    {
                        "Applicant", "Auto mechanic", "Agronomist", "Lawyer", "Actor / Actress",
                        "Bartender", "Businessman", "Botanist", "Bookmaker", "Driller", "Accountant", "Watchman", "Veterinarian",
                        "Winemaker", "Miron", "Virologist", "Serviceman", "Thief", "Prostitute", "Gamer", "Genetician", "Geographer", "Maid",
                        "Trucker", "Taster", "Diplomat", "Doctor", "Milkmaid", "Jockey", "Inventor", "Engineer", "Hookah Man", "Film Director",
                        "Clown", "Collector", "Lieutenant", "Butcher", "Drug lord", "Oncologist", "Brewer", "Cook", "Porn actor", "Programmer",
                        "Foreman", "Streamer", "Builder", "Judge", "Sushist", "Tractor Driver", "Pharmacist", "Hacker", "Economist", "Lawyer", "Nikita"
                    }
                }
            },
            {
                "Skills", new DataParams
                {
                    Skill = new List<Skill>
                    {

                        new Skill { FirstSkill = "Can change his profession to a random one if he is at least 18 or older than 27. Otherwise he becomes a Soldier.", SecondSkill = "Can go without food for two weeks."},
                        new Skill { FirstSkill = "Knows where the workshop is.", },
                        new Skill { FirstSkill = "Adds a crate of groceries to your inventory.", },
                        new Skill { FirstSkill = "Once per game, can redirect a vote to yourself that was against some player.", },
                        new Skill { FirstSkill = "Can use any player's profession ability.", },
                        new Skill { FirstSkill = "Once per game can add the health condition “Alcoholism (mild)” to any player.", },
                        new Skill { FirstSkill = "Can take the exiled player's open inventory.", },
                        new Skill { FirstSkill = "Adds any plant seeds to your inventory.", },
                        new Skill { FirstSkill = "Can swap two players' hobbies.", },
                        new Skill { FirstSkill = "Adds a drill with a full charge to your inventory (the charge is enough for 24 hours of active work).", },
                        new Skill { FirstSkill = "Can change the amount of food in the bunker from \"lack\" to \"too much\" and vice versa.", },
                        new Skill { FirstSkill = "Adds a safe to your inventory.", },
                        new Skill { FirstSkill = "Adds any animal to inventory (up to 50 kg.)", },
                        new Skill { FirstSkill = "When it enters the bunker, it will carry a case of wine with it.", },
                        new Skill { FirstSkill = "Once per game can learn all information about any person", },
                        new Skill { FirstSkill = "Adds 1 Universal Vaccine against Airborne Infections to inventory.", },
                        new Skill { FirstSkill = "Adds a pistol and 28 bullets to inventory", },
                        new Skill { FirstSkill = "Can steal another player's inventory.", },
                        new Skill { FirstSkill = "Can heal anyone once per game", },
                        new Skill { FirstSkill = "Been through all the survival games and knows a couple of valuable tips on how to survive in an extreme situation.", },
                        new Skill { FirstSkill = "Greatly increases the chance of having healthy babies when hit in a bunker.", },
                        new Skill { FirstSkill = "Adds a terrain map to your inventory.", },
                        new Skill { FirstSkill = "Adds a disinfection kit to your inventory.", },
                        new Skill { FirstSkill = "Adds a stack of porn magazines to your inventory.", },
                        new Skill { FirstSkill = "Immune to alcohol-related phobias and diseases. Adds 10 liters of any drink to your inventory.", },
                        new Skill { FirstSkill = "At will, can cancel a friend's or enemy's card if one is directed at him.", },
                        new Skill { FirstSkill = "Once per game, can cure any \"mild\" or \"moderate\" disease to any player other than himself.", },
                        new Skill { FirstSkill = "Adds a cow to your inventory.", },
                        new Skill { FirstSkill = "Adds a horse to your inventory.", },
                        new Skill { FirstSkill = "When you hit the bunker, an automatic egg incubator will appear in your inventory.", },
                        new Skill { FirstSkill = "When entering the bunker, it adds an equipped hookah room. The size of the bunker does not change.", },
                        new Skill { FirstSkill = "Can regenerate the \"Add. information\".", },
                        new Skill { FirstSkill = "Can change skills clockwise. Works once per game.", },
                        new Skill { FirstSkill = "Can steal inventory from any player.", },
                        new Skill { FirstSkill = "Может украсть инвентарь у любого игрока.",  },
                        new Skill { FirstSkill = "May remove 1 downvote when voting."},
                        new Skill { FirstSkill = "Adds 5kg of raw smoked meat to your inventory."},
                        new Skill { FirstSkill = "Adds 2 sachets (100g each) of the same herbs for depression to any player's inventory."},
                        new Skill { FirstSkill = "Can reduce cancer disease to Mild (once per game).\n* Cannot be cast on a player whose disease is \"Critical\".\n* Cannot be cured."} ,
                        new Skill { FirstSkill = "Adds 10 pack of Doshirak to your inventory."},
                        new Skill { FirstSkill = "Has the ability to heal childfree of the opposite sex."},
                        new Skill { FirstSkill = "Can regenerate any player's skill except himself."},
                        new Skill { FirstSkill = "Can split any room in the bunker into 2 rooms."},
                        new Skill { FirstSkill = "Can unlock an additional stat on your turn (once per game)."},
                        new Skill { FirstSkill = "Adds any room to the bunker. The size of the bunker does not change."},
                        new Skill { FirstSkill = "If the players got an equal number of votes during the voting, it can decide who to kick. The decision can be made once per game."},
                        new Skill { FirstSkill = "Adds 2kg of sushi to inventory."},
                        new Skill { FirstSkill = "Can say \"300\" and get 2kg of grain in inventory."},
                        new Skill { FirstSkill = "Knows the location of the medical supply store."},
                        new Skill { FirstSkill = "Adds a laptop with a charger to your inventory."},
                        new Skill { FirstSkill = "Able to calculate the amount of food in such a way that it will last for 1 more month."},
                        new Skill { FirstSkill = "Can decide (regardless of other players' opinions) whether to vote in a round or skip voting."},
                        new Skill { FirstSkill = "Player turns into a bear and kills one player (optional)"},
                    }
                }
            },
            {
                "SecondSkill", new DataParams
                {
                    Text = new List<string>
                    {
                        "Adds one place to the bunker", "Allows you to cure any disease of any player except you", "The player opposite you must not enter the bunker", "Removes snakes from the bunker", "Protects any player for one turn (except you)" ,
                        "There is an armory near the bunker", "Any player chooses to reveal his hobby", "Allows you to learn another player's hobby", "The player to your left must get into the bunker", "The bunker is in the forest",
                        "There is a bunker near you with two female chemists (Full health / age: 25-45 years old)", "Allows you to exchange phobias with another player", "There is a tank near the bunker", "Removes spiders from the bunker",
                        "Allows you to activate map number 2 of the player of your choice", "adds spiders to the bunker", "Everyone will know that the bunker is on a desert island",
                        "Exchange professions from left to right", "There is a bunker with aggressive survivors near you", "You can exchange health with another player",
                        "You can change professions with another player", "Clears a place from the bunker", "There is a bunker near you with all the brazzers actresses (Fully healthy / age: 20-45 years old);"
                    }
                }
            },
            {
                "Sex", new DataParams
                {
                    Text = new List<string>
                    {
                        "Man", "Woman"
                    }
                }
            },
            {
                "Age", new DataParams
                {

                }
            },
            {
                "SexualOrientation", new DataParams
                {
                    Text = new List<string>
                    {
                       "Heterosexual", "Gay", "Lesbian", "Bisexual", "Queer (Weird)", "Asexual", "Aromantic", "Androsexual", "Gynosexual", "Demisexual", "Pansexual", "Transvestite"
                    }
                }
            },
            {
                "Health", new DataParams
                {
                    Text = new List<string>
                    {
                        "Perfectly healthy", $"Cancer {Random.Range(1, 5)} degrees", "Drug addict", "One eye to the Caucasus, the other to Arzamas (strabismus)", "Tuberculosis", "Heartburn", "Rabies" , "Colorblind", "Scoliosis",
                         "Schizo", "Hepatitis B", "HIV", "Covid-19", "Delirium", "Psychosis", "Flatfoot", "Crystal Man Syndrome", "Rickets", "Bulimia", $"AIDS (Will Die in {Random.Range(2, 4)} years", "Generally healthy",
                         "Hemorrhoids", "Alzheimer's", "Breast Cancer", "Mild Alcoholism", "Blood Cancer (will die in a year)", "Diabetes", "Acne", "Legless", "Armless", "Mute"," Paranoia"
                    }
                }
            },
            {
                "Hobby", new DataParams
                {
                    Text = new List<string>
                    {
                        "Collects bugs and spiders", "Spends time with birds", "Trainsurfing", "Collecting beer can rings", "Hacking terminals", "Dancing", "War games", "Cartography", "Cooking", "Shoot guns",
                        "Photographer", "Drinking Beer", "Skydiving", "Rock Climbing", "Streetluge", "Motorcycle Ride", "Passing Couples", "Soap Making", "Weapon Making", "Bodybuilding & Weightlifting",
                        "Growing Plants", "Beer Brewing", "Cheese Making", "Tea Drinking", "Eating Fly Agaric", "Search for a Bookmark", "Earning as a Taxi Driver (I Have My Own Business)", "Pick-up Drinking", "Archery", "Boxing ", "To breed animals",
                        "Programming", "Participation in charitable and socially significant projects", "Gardening", "masturbation", "Martial arts", "Historical reconstructions", "Card games", "Tennis", "Building design"
                    }
                }
            },
            {
                "CharacterTraits", new DataParams
                {
                    Text = new List<string>
                    {
                        "Kindness", "Honesty", "Loyalty", "Responsiveness", "Generosity", "Humor", "Accuracy", "Fearlessness", "Active", "Wise", "Semperature", "Observant", "Optimist", "Luck", "Responsiveness",
                        "Romantic", "Persistent", "Punctuality", "Correction", "Calm", "Industriousness", "Sense of Duty", "Enthusiasm", "Elegance", "Economy", "Persistence", "Perseverance", "openness", "sociability",
                        "Harmful", "Grumbling", "Seclusion", "Laziness", "Hypocrisy", "Unsociable", "Persistence", "Courage", "Wisdom", "Selfishness", "Irritability", "Passivity", "Greed", "Tolerance", "Calm"
                    }
                }
            },
            {
                "Phobia", new DataParams
                {
                    Text = new List<string>()
                    {
                        "No", "Selachophobia - fear of sharks", "Nosophobia - fear of disease", "Algophobia - fear of pain", "Brontophobia - fear of thunder", "Ripophobia - fear of dirt", "Claustrophobia", "Eisoptrophobia - fear of mirrors", "Ophidiophobia - fear of snakes",
                        "Arachnophobia - fear of spiders", "Thanatophobia - fear of death", "Achluophobia - fear of the dark", "Aetatemophobia - fear of aging", "Carcinomatophobia - fear of cancer", "Skelerophobia - fear of bad people",
                        "katagelophobia - fear of ridicule", "Aichmophobia - sharp objects", "Dysmorphophobia - fear of physical defects", "Aquaphobia - fear of drowning", "Trypanophobia - fear of injections", "Pnigophobia - fear of strangulation",
                        "Necrophobia - fear of corpses", "Iatrophobia - fear of doctors", "Acrophobia - fear of heights", "Glossophobia - fear of speaking in public", "Sociophobia", "Pyrophobia - fear of fire",
                        "Eremophobia - fear of loneliness", "Katagelophobia - fear of ridicule", "Spermophobia - fear of microbes", "Dentophobia - fear of dentists", "Hematophobia - fear of blood", "Rodentophobia - fear of rats",
                        "Gravidophobia - fear of meeting with a pregnant pregnancy"
                    }
                }
            },
            {
                "Additionally", new DataParams
                {
                    Text = new List<string>
                    {
                        "Accurate", "well versed in higher mathematics", "Jew", "Negro", "He got hit by a bream", "Has psychic abilities", "Knows where the supplies of seeds per hectare are",
                        "Knows where food supplies are for two months", "Founder of CBD", "Good with animals", "Disabled", "Knows how to juggle", "Took hairdresser's course",
                        "Hates modern music", "Survived three assassination attempts", "Has a phenomenal memory", "Nobel laureate", "No", "Hates men", "Communist", "Knows his name",
                        "Knows how to breathe", "Knows how to use a pen", "Knows how to open canned food", "This catastrophe is a conspiracy of reptiles", "Believes in aliens", "Schizik", "Believes in God", "Believes in the Devil", "He is fond of hunting",
                        "Read a book about survival on a desert island", "Suffers from seasickness", "Designed this bunker", "May be able to provide first aid", "Took a cooking course", "Coprofil",
                        "The founder of the blue moon", "Owns an anti-cafe", "Can light raw firewood", "Escaped from prison", "Won all school quests", "Friends with Timati. Popped a burger for the health of a sobyanin", "Survival expert",
                        "Advertised the LDPR Party", "Knows how to cook bugs", "Has 4 million followers on Instagram", "Once drank the blue lord", "Makes delicious potato pancakes"
                    }
                }
            },
            {
                "SmallLuggage", new DataParams
                {
                    Text = new List<string>
                    {
                        "Feathers", "Bandages", "Pincent", "Phone", "Cookware set", "Gun", "A year's supply of pasta", "Watch", "Empty cardboard box", "Soap", "Rope", " Baton", "Flashlight and spare batteries",
                        "Kitchen tool set", "Vibrator", "Security camera", $"Porn magazines ({Random.Range(1, 8)} pcs)", "Pen", "ABC", "Wireless speaker", "Lipple "," Gum (mint)",
                        $"Strip test ({Random.Range(1, 4)} pcs)", "Shavers", "Water bottle (5gallon)", "Mirror", "Traps", "Meals for one week", " Tweezers", "Alarm Clock", "Manicure Book", "Georgian Tea", "Indian Tea",
                        "Four walkie-talkies", "Needle and thread", "US flag", "Flint", "Battery", "Backpack", "Compass", "Cast-iron utensils", "Used syringe", "Photograph of the earth from space", " condoms",
                        "Spider", "Turtle", "Toys", "Crowbar", "Shovel", "Grenade", "Suitcase", "Poker", "Joystick", "Passport", "Morse code book", "Persian cat "," Cartridges for a pistol (24 pcs)", "Two cans of beer",
                        "Vodka bottle", "Ten disposable medical masks", "Red diploma", "Telephone", "Potato seeds", "Hammer and nails", "Iron pipe", "Sunglasses", "A ring with a diamond",
                        "Tool set", "Kidney"

                    }
                }
            },
            {
                "BigLuggage", new DataParams
                {
                    Text = new List<string>
                    {
                        "A year's supply of pasta", "Fire extinguisher", "Engine", "Generator", "Cow with food for 3 months", "Bicycle", "Axe", "Roll of toilet paper (100 m)", "Ambulance paramedic kit ",
                        "Lego car constructor for 521 parts", "Board games (3 pcs)", "Assault rifle with 3 horns", "RZK suit (2 pcs)", "Role-playing game suit", "Building set", "Radio station ", "German Shepherd",
                        "Meals for one month", "TV", "Sleeping bags", "Drawing", "Window", "Operation kit", "Air freshener packaging", "Cash register", "A4 white paper packaging",
                        "Refrigerator", "Toilet", "Coffin", "Trampoline", "Door", "Wheel from Belaz", "Penguin", "C4", "Vacuum cleaner", "Lawn mower", "Tractor", "Chair with peaks chiseled", "Two cows", "Ferret", "Cat", "Dog"
                    }
                }
            },
            {
                "BunkerName", new DataParams
                {
                    Text = new List<string>
                    {
                        "77", "Nemo", "Alpha", "1771", "Ob. 99", "Lengov", "Armata", "VVO", "ATUB", "Gintor", "Nevs", "Beta", "Gamma", "Delta", "Lambda", "Early 997", "Werewolf",
                    }
                }
            },
            {
                "BunkerPlace", new DataParams
                {
                    Text = new List<string>
                    {
                        "Desert", "Reserve", "Forest", "Desert Island", "City", "Tropics", "Mountains", "Village", "Slums", "Field", "Tundra", "Baikal", "Forest", "Marshland", "Planktation", "Werewolf",
                    }
                }
            },
            {
                "BunkerArea", new DataParams
                {
                    Text = new List<string>
                    {
                        "47", "100", "89", "55", "170", "139", "350", "320", "120", "80", "300", "187", "145", "200", "250", "240", "129", "192", "77", "215"
                    }
                }
            },
            {
                "BunkerResources", new DataParams
                {
                    Text = new List<string>
                    {
                        "First aid kit", "Winter clothes", "First aid kit", "Instruction for survival in the forest", "Radio;", "Tool kit", "Drums", "Soft toys", "First aid kit",
                        "Moonshine still", "Broken generator", "Generator with gasoline", "A set of dry rations", "A set of tomato soups", "Water supply", "Checkers", "Chess", "Flashlight", "Axe",
                        "Playing Cards", $"Rifle with {Random.Range(1, 9)} clip", "Bong", "Suitcase with Clothes", "Flashlight", "Area Map", "Rat Poison", " Tuba", "Guitar", "First Aid Kit",
                        "Snus", "Bayan", "Table lamp", "Cosmetic bag", "Tutorial on how to survive in a bunker", "Winter clothes", "Wetsuit with an air tank"
                    }
                }
            },
            {
                "BunkerBuildings", new DataParams
                {
                    Text = new List<string>
                    {
                        "Greenhouse", "Broken Greenhouse", "Office Room", "Dining Room", "Chemical Lab", "Provision Warehouse", "Research Lab", "Barbershop", "Empty Warehouse", "Shower Room",
                        "Generator with gasoline", "Workshop with tools", "Medical office", "Radio station", "Gym", "Assembly hall (with stage)", "Room with a lathe",
                        "Meth Lab", "Weapons Depot", "Basement", "Room Full of Hentai Comics", "Prepared Operating Room", "Moonshine Still", "Information Technology Room",
                        "Disguised Surface Observation Tube", "Destroyed Medical Room", "Crowded Armory", "Several Bedrooms", "Broken Chem Lab", "Greenhouse",
                        "Destroyed Greenhouse", "Landed Greenhouse", $"Landed Bedroom with {Random.Range(1, 7)} bed", "Empty Room"
                    }
                }
            }
        };
    }
}
