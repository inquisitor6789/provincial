﻿if $args[0] = '' or $args[0] = 'start':
	*clr & cla
	housevorrand = RAND(0,200)
	gs 'stat'
	if hour > 22 and housevorrand = 0 and housrA = 1 and husband = 0: gt 'bed', 'vor'
	gs 'zz_render', 'Кровать', iif(current_clothing = 0 and tanga = 0,'images/pics/son.jpg',iif(current_clothing = 0 and tanga = 1,'images/pics/son_tanga.jpg','images/pics/bed.jpg')), 'Вы лежите на кровати. Будильник заведен на <<timer>> часов, <<timerM>> минут. (Будильник <a href="exec: budilnikOn = ' + iif(budilnikOn=0, 1, 0)  + ' & gs ''bed'',''start''">' + iif(budilnikOn=0, 'выключен', 'включен') + '</a>)'
	act 'Завести будильник': gt 'budilnik', 'start'
	if son < 10:
		act 'Раздеться и лечь спать':
			mira_guest = 0
			notathomesleep += iif($loc = 'bedrPar',-notathomesleep,1)
			gs 'bed', 'sleep'
		end
	else
		gs 'zz_render', '', '', 'Спать почему то не хочется.'
		act 'Постараться уснуть':mira_guest = 0 & gs 'bed', 'sleep'
	end
	act 'Встать с кровати': InSleep = 0 & gt $loc, $metka
	if horny >= 60 and $sister['location'] ! $loc and $loc ! 'Gadhouse': act 'Мастурбировать': gt 'selfplay'
	exit
end
if $args[0] = 'vor':
	*clr & cla
	minut += 60
	'<center><img src="images/img/spaln/g0.jpg"></center>'
	'Вы легли на кровать, как вдруг услышали какой-то звук в коридоре. Только вы решили встать посмотреть как в комнату вбежали двое в масках, не успели вы рта раскрыть как у вашего горла оказался нож. "Только пискни сука, прирежу." прохрипел один из них. Они связали вам руки и один отправился обыскивать квартиру, а второй остался вас сторожить. Он сидел и внимательно вас рассматривал, затем взял нож и начал водить им по вашему телу "Что, страшно?" спросил он, решив что лучше вам молчать вы ничего не ответили а потупив взгляд смотрели в пол. "Вижу что страшно" ухмыльнулся он. Затем он начал щупать вас, вы попытались отодвинуться, но нож вновь оказался у вашего горла "Сиди смирно сучка, пока на перо не посадил" прохрипел он и продолжил вас ощупывать. Наконец вернулся второй "Все валим отсюда" сказал он.'
	'"Подожди давай эту соску помнем, смотри какая сочная" сказал сидевший с вами,'
	if vnesh >= 60:
		guy += 2
		bj += 1
		sex += 1
		rape += 1
		'"А что, смачная соска, когда еще такую доведется трахнуть" сказал первый.'
		act 'Умолять':
			*clr & cla
			minut += 30
			'<center><img src="images/img/spaln/g1.jpg"></center>'
			'Вы сжались от ужаса, "Ну что соска вставай на колени и открывай рот, да смотри, коснешься зубами, от уха до уха глотку вскрою" сказал второй доставая член. Вы начали умолять не трогать вас, но получив оплеуху встали на колени. Он ткнул членом вам в губы, вы нехотя открыли рот и тут же его член оказался у вас во рту, сжав руками вашу голову он начал трахать вас в рот, за тем тоже сделал второй, потом они попытались засунуть вам в рот оба члена, но решив, что их члены будут друг друга касаться, а это по их мнению, даже если они в женском рту, голубизной попахивает, вернулись к первому варианту и продолжили насиловать ваш рот по очереди. Все происходящее должно было вызывать у вас отвращение, что и было первые пару минут, но затем вы с удивлением поймали себя на том, что их руки теперь просто лежат на вашей голове, а все движения вы делаете сами и уже активно работаете языком.'
			'"Давай раком вставай" скомандовал один.'
			act 'Встать':
				*clr & cla
				picrand = 38
				orgasm += 1
				'<center><img src="images/img/spaln/g2.jpg"></center>'
				'Вы поднялись и нагнулись один из них встал сзади и приставив член к вашей киске, вошел внутрь. "Да она все течет, слышь Серый этой сучке нравится" сказал он.'
				'"Пасть закрой" рыкнул на него второй, вставляя член вам в рот. Они продолжили насиловать вас с двух сторон, но вас переполняло желание, вы стояли раком со связанными за спиной руками и двое незнакомцев имели вас. Вы старательно подмахивали одному одновременно обсасывая член второго как вдруг в глазах потемнело, по телу пробежала приятная дрожь и вы забились в оргазме. Тот что имел ваш рот выдернул член "Что с этой сукой, у неё что эпилепсия" вскрикнул он. "Да, нет, я же говорил что её нравиться, эта сучка кончила." ответил второй. Они развязали вам руки "Посмотрим на что она способна с развязанными руками" сказал один.'
				act 'Продолжать':xgt'sexdvoe','var'
			end
		end
	elseif vnesh < 60:
		'"Валим я сказал" повторил первый "И пасть ей закрой" добавил он. Второй не стал спорить и взяв белье из вашего шкафа затолкал вам в рот. "Если раньше чем через полчаса вылезешь, тебе не жить" сказал первый и они ушли. Вы не стали выжидать полчаса и начали пытаться освободиться, хорошо что узлы они толком вязать не умели и скоро вам удалось развязаться'
		act 'Оценить ущерб':gt'bed','vorend'
	end
end
if $args[0] = 'vorend':
	*clr & cla
	'<center><img src="images/pic/sitr'+iif(remsitr = 0,'',2)+'.jpg"></center>'
	'Когда все кончилось, вы проходите по квартире посмотреть что пропало.'
	if stolmoney > 0:
		stolmoney = 0
		'Они забрали <<stolmoney>> рублей из стола.'
	end
	if money > 0:
		money = 0
		'Они забрали <<money>> рублей которые вы носили с собой.'
	end
	if komp = 1:
		'Они забрали ноутбук.'
		komp = 0
	end
	gs 'stat'
	act 'Закончить': gt'sitr'
end
if $args[0] = 'sleep':
	*clr & cla
	gs 'zz_clothing', 'decrease_condition'
	gs 'zz_clothing', 'redress', 0
	! сон на голодный желудок не востанавливает здоровье
	if energy >= 8: health += 5
	InSleep = 1
	hapri = 0
	! штраф за алко
	if alko > 1:
		manna = manna/(iif(alko>=6,3,iif(alko>=3,2,1)))
		water -= iif(alko>=6,20,iif(alko>=3,10,5))
	end
	! переведем время в минуты
	zz_time = hour*60 + minut
	! переведем время будильника в минуты
	zz_bud_time = timer*60 + timerM
	if zz_bud_time < zz_time: zz_bud_time += 24*60
	! получаем разницу необходимого и текущего значения снов
	if son > 24: son = 24
	delta_son = 24 - son
	! считаем, сколько часов надо спать
	! в час у нас son*3
	if alko < 3 and sick = 0:zz_sleep_time = delta_son / 3
	if alko >= 3 or sick > 0:zz_sleep_time = delta_son / 2
	! добавим слегка минут сна
	delta_son_minutes = 0
	if delta_son mod 3 = 1: delta_son_minutes = 20
	if delta_son mod 3 = 2: delta_son_minutes = 40
	! просчитываем время подъема
	zz_wakeup = zz_time + zz_sleep_time * 60 + delta_son_minutes
	! подъем по будильнику
	if budilnikOn = 1 and zz_wakeup > zz_bud_time:
		! сколько часов будет спать гг до будильника
		delta_son = zz_bud_time - zz_time
		! значение сна в момент подъема
		if alko < 3:son += 3 * delta_son / 60
		if alko >= 3:son += 2 * delta_son / 60
		! переводим время
		minut += delta_son
	else
		! сон без будильника
		son = 24
		! переводим время
		minut += zz_wakeup - zz_time
	end
	! ритуальное убиение временных переменных
	killvar 'zz_time'
	killvar 'zz_bud_time'
	killvar 'delta_son'
	killvar 'zz_sleep_time'
	killvar 'delta_son_minutes'
	killvar 'zz_wakeup'
	! сон
	gs 'bed', 'dreaming'
	! пересчет статов
	gs 'stat'
	if mop ! 1: mop = 1 & pl 'Перед сном вы сходили в ванную и смыли косметику.'
	if analplugIN = 1: analplugIN = 0 & pl 'Перед сном вы вынули анальную пробку.'
	if vibratorIN = 1: vibratorIN = 0 & pl 'Перед сном вы вынули вибратор.'
	if budilnikOn = 1 and (timer*60 + timerM) = (hour*60 + minut):
		gs 'zz_render', '', '', 'Звенит будильник'
		manna -= 3
	end
	if oversleep = 1: gs 'zz_render', '', '', '<dh>Черт, черт, черт! Вот тебе и "подремаю еще минутку"!</dh>'
	act 'Еще минутку...': gs 'bed', 'relax'
	act 'Встать с кровати и одеться (15 минут)':
		cla
		if prev_clothing < 0: prev_clothing = 0
		gs 'zz_clothing', 'redress', prev_clothing
		prev_clothing = -1
		InSleep = 0
		minut += 15
		if clothesswamphouse = 1 or clothesbackwater = 1: gs 'zz_clothing', 'redress', 0
		if swamp_clothes = 1: gs 'zz_clothing', 'redress', 1
		gs 'stat'
		gt $loc, $metka
	end
	if shameless['flag'] >= 2:
		act 'Встать с кровати':
			cla
			InSleep = 0
			flag_tanga = tanga
			gt $loc, $metka
		end
	end
	act 'Постараться уснуть': gs 'bed', 'sleep'
	oversleep = 0
	if disable_autosave = 0: SAVEGAME 'autosave.sav'
	exit
end
if $args[0] = 'relax':
	minut += rand(5,10)
	! еще минутку и... проспала
	! за окном дождь, холодно; плохое настроение; попоболь
	i = 0
	if son < 20:
		if sunWeather < 0:  i += 1
		if son < 10: i += 1
		if manna < 33: i += 1
		if painpub > 0: i += 1
		if nippain > 0: i += 1
		if sick > 0: i += 1
		if mesec > 0: i += 1
		if preg > 0: i += 1
		if spanked > 0: i += 1
		if alko > 0: i += 1
	end
	if rand(0, iif(son <= 10, 10, 20) - i) < 3:
		oversleep = 1
		gs 'bed', 'sleep'
	else
		gs 'bed', 'start'
	end
	exit
end
if $args[0] = 'dreaming':
	!случайные сны ни о чем
	$_str[0] = 'Вам снится какой-то старый город, стоящий на противоположных берегах высокого водопада, а между его шпилей летают какие-то существа.'
	$_str[1] = 'Вам снится какая-то башня, окутанная снегом льдом на вершине замерзшей скалы.'
	$_str[2] = 'Вам снится ледяная гора, на вершине которой стоит непонятное здание похожее на монастырь.'
	$_str[3] = 'Вам снится высокая незнакомая девушка, идущая под проливным дождем по темной и узкой улице.'
	$_str[4] = 'Вам снится ваша улыбающаяся мать в комнате, полной старых вещей из прошлого или позапрошлого века. Странно, к чему бы это?'
	$_str[5] = 'Вам снится какой-то всадник, стоящий у озера, окруженного высокими и отвесными горами.'
	$_str[6] = 'Вам снится страшный мужчина с обгоревшей кожей, держащий на цепи непонятное существо, пока на него с мечом идет беловолосый средних лет парень. Пора прекращая смотреть телевизор...'
	$_str[7] = 'Вам снова снится беловолосый парень, но заметно постаревший и с густой бородой, а рядом с ним стоит красивая беловолосая девушка. Может это его дочь? Почему вам вообще это снится?'
	$_str[8] = 'Вам снится, будто вы стоите среди людей на улице и наблюдаете большой ядерный гриб. О, боже, как это страшно!'
	$_str[9] = 'Вам снится плотнозастроенная из какого-то мусора улица и большая очередь к какому-то прилавку.'
	$_str[10] = 'Вам снится красивый и величественный собор на берегу реки.'
	$_str[11] = 'Вам снится, что вы стоите зимой на берегу озера и наблюдаете за темной фигурой, стоящей на окруженной водой верандой, под светом Луны, которая почему-то выглядит как светящийся циферблат часов.'
	!только эротика
	$_str[12] = 'Вам снится, что в школе всех девочек обязали присутствовать на уроках только в обнаженном виде.'
	$_str[13] = 'Вам снится, что вас голую ласкает какой-то атлетичный парень на диване. Он целует вашу шею и опускается поцелуями к вашей груди, лаская своим языком ваши сосочки.'
	$_str[14] = 'Вам снится, что вы моетесь голышом в душе с каким-то парнем. Он мылит ваше тело, уделяя особое внимание вашей груди и киске, в то время как его твердый член упирается вам в спину.'
	$_str[15] = 'Вам снится, что вы голышом целуетесь и ласкаете друг-друга с какой-то девушкой на кровати.'
	$_str[16] = 'Вам снится, что вы абсолютно голые страстно целуетесь с каким-то незнакомым парнем.'
	!только минет
	$_str[17] = 'Вам снится, что вы, стоя раком, попкой к верху, делаете минет какому-то парню в лучах заката, на берегу океана.'
	$_str[18] = 'Вам снится, что вы, прикованная к лестнице, сидя на корточках с широко раздвиннутыми ножками, смакуя отсасываете член какому-то парню в хорошем костюме.'
	!только вагинальный секс
	$_str[19] = 'Вам снится, что вы занимаетесь сексом с атлетичным парнем возле бассейна дорогого особняка. Вы скачете верхом на его члене, пока он крепко сжимает вашу попку.'
	$_str[20] = 'Вам снится, что вы занимаетесь сексом с незнакомым парнем на диване. Он нежно вас целует и ласкает вашу грудь руками, пока его член поршнем работает в вашей текущей киске.'
	$_str[21] = 'Вам снится, что вы на берегу океана занимаетесь сексом с незнакомым парнем. Вы лежите вся в песке, а он ритмично имеет вас в миссионерской позе, лаская поцелуями вашу шею.'
	$_str[22] = 'Вам снится, что вас на светлом диване жестко имеет раком какой-то парень. Он крепко сжимает своими руками вашу попку, а вы старательно подмахиваете ему, прикусив губу от удовольствия.'
	$_str[23] = 'Вам снится, что вы скачите верхом на крепком члене какого-то парня.'
	!только анальный секс
	$_str[24] = 'Вам снится, что вас раком жестко имеет в попку какой-то парень, пока вы теребите пальчиками свой клитор.'
	$_str[25] = 'Вам снится, что вас сзади, на боку трахает в попку парень, а вы громко стоните'
	!только групповуха
	$_str[26] = 'Вам снится, что вы занимаетесь сексом с двумя парнями. Вы лежите между ними и смакуете член одного, пока другой имеет вас в попку.'
	$_str[27] = 'Вам снится, что вас страстно трахают в два ствола какие-то парни. Их члены, как поршни, поочередно и с силой входят в обе ваши дырочки и вы громко стонете от удовольствия.'
	! reaction
	$after[0] = 'Вы еще ни разу не делали никому минет, но ощущения и форма члена в вашем ротике были настолько реальные, что это одновременно вас испугало и не на шутку возбудило.'
	$after[1] = 'Похоже, что ваше подсознание очень настойчиво вам намекает.'
	$after[2] = 'В вашей дественной киске и члена-то ни разу не было, но ощущения были настолько реальные что вас это не на шутку возбудило.'
	$after[3] = 'В вашей киске и члена-то ни разу не было, хоть вы и не девственница, но ощущения были настолько реальные что вас это не на шутку возбудило.'
	$after[4] = 'Похоже, что ваша <<$vaginatipe>> киска срочно требует чем-то себя заполнить.'
	$after[5] = 'У вас ни разу не было анального секса, но ощущения были настолько реальные что вас это не на шутку возбудило.'
	$after[6] = 'В вашей попке и члена-то ни разу не было, хоть она и не девственна, но ощущения были настолько реальные что вас это не на шутку возбудило.'
	$after[7] = 'Похоже, что ваш <<$anustipe>> анус срочно требует чем-то себя заполнить.'
	$after[8] = 'Похоже, что одного парня за раз вам в ваших снах совсем недостаточно...'
	$after[9] = 'Похоже, что ваш опыт групповухи с не прошел даром и ваше подсознание активно вам об этом напоминает.'
	! set default - nothing
	_after = -1
	if $npc['35,qwOtchim'] = 3:
		i = 28
		$_img = 'qwest/alter/father/bath_voyer_1.jpg'
		$_str[28] = 'Сегодня вам приснился весьма странный сон: вы с завязанными глазами занимались сексом с незнакомцем и лишь по завершению действа, сняв повязку, вы узнали своего отчима.'
		if horny < 90: horny = 90
	else
		if horny <= 50:
			i = rand(0,iif(manna > 60,16,11))
		else
			if bj > 0:
				i = rand(12,23)
			elseif sex > 0:
				i = rand(12,25)
			elseif anal > 0 or gang > 0:
				i = rand(12,27)
			else
				! default value
				i = rand(12,18)
			end
		end
		if i = 17 or i = 18: _after = iif(bj = 0, 0, 1)
		if i >= 19 and i <= 23: _after = iif(vagina = 0, 2, iif(sex = 0, 3, 4))
		if i = 24 or i = 25: _after = iif(anal = 0, iif(anus = 0, 5, 6), 7)
		if i > 25: _after = iif(gang = 0, 8, 9)
		horny += iif(i < 12, 0, iif(i < 24, 10, 20))
	end
	gs 'zz_render', 'Сон', iif(i > 27, $_img, 'pic/dreams/' + i + '.jpg'), $_str[i] + '<br/>' + iif(_after < 0,'',$after[_after])
	killvar '$after'
	killvar '_after'
	killvar '$_img'
	killvar '$_str'
end