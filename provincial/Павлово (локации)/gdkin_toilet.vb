﻿dentoilet = daystart
gs 'npc_editor','init_sex',10
minut += 10
gs 'stat'
*clr & cla
if vagina = 0:
	gs 'zz_render','','pavlovo/dk/disco/dk_toilet/Den_dk_01.webm','Распарившись после очередного танца вы заходите в туалет, чтобы привести себя в порядок, покурить и промочить горло остатками пива - бурные пляски вызывают бурную жажду.
Случайно или нет, но следом за вами в туалет заходит Дэн и, внимательно вас оглядев, проходит к толчку.
Закончив свои дела, Дэн подошел к вам и, угостив сигареткой, завязал пустой разговор ни о чем.
Какое-то время вы болтали, пока, наконец, до вас не дошло, что для Дэна разговор был совсем не пустой: опустив глаза, вы поняли, что он имеет вполне определенные намерения и полностью готов их осуществить - его член прям-таки рвался из штанов.
\\\- Ладно, <<$name[1]>>, не тяни кота за хвост, отсоси мне по-быстрому, и пойдем в зал, пока эти жлобы все пиво не вылакали.///'
	act 'Подчиниться':
		*clr & cla
		dom -= 1
		gs 'zz_render','','pavlovo/dk/disco/dk_toilet/Den_dk_02.webm','Понимая, что деваться вам некуда и что молчание Дэна - единственная гарантия того, что вы не пойдете в Павлово по рукам… ну, не совсем по рукам, блин, даже думать об этом не хочется, вы встали на колени, расстегнули Дэну ширинку и достали его член.'
		act 'Ласкать ртом':
			*clr & cla
			dom -= 1
			gs 'zz_render','','pavlovo/dk/disco/dk_toilet/Den_dk_03.webm','- Ну, чего смотришь? Облизни его.
Пару минут вы обрабатываете член Дэна, проводя язычком по всей его длине, лижете яйца и снова член.
\\\- А теперь давай, ручками-губками, все как ты умеешь/// - Дэн ухмыляется. Вас бесит его ухмылка, но вы покорно выполняете наглое требование парня.'
			act 'Сосать':
				*clr & cla
				horny += 10
				gs 'stat'
				gs 'zz_render','','pavlovo/dk/disco/dk_toilet/Den_dk_04.webm','Поработав ртом и руками несколько минут, вы чувствуете, что Дэн вот-вот кончит. Еще несколько движений, еще…
"Ну давай же - думаете вы про себя, ну..."
\\\-Стой/// - Дэн тяжело дышит - \\\повернись ка попкой...///'
				act 'Продолжить сосать':
					*clr & cla
					gs 'zz_render','','pavlovo/dk/disco/dk_toilet/Den_dk_05.webm','В ответ вы только замычали что то непонятное и лишь удвоили свои старания.
\\\-А-а-а-а.../// - Дэн разрядился вам в рот.
\\\- Черт, возьми, какого хрена? Хотя так тоже не плохо.///
\\\- Все заглатывай, не трусами же мне вытирать///, - говорит Дэн.'
					act 'Чистить':
						*clr & cla
						if $npc['10,sex'] = 0: $npc['10,sex'] = 1 & guy += 1
						bj += 1
						swallow += 1
						if throat < dick: throat += 1
						gs 'zz_funcs', 'cum', 'face'
						minut += 10
						gs 'stat'
						gs 'zz_render','','pavlovo/dk/disco/dk_toilet/Den_dk_06.webm','Не желая спорить, вы досуха высасываете остатки спермы из его члена. После того, как Дэн ушел, вы идете к умывальнику и приводите себя в порядок.'
						act 'Привести себя в порядок': gt 'zz_toilet'
					end
				end
				act 'Повернуться':
					*clr & cla
					gs 'zz_render','','pavlovo/dk/disco/dk_toilet/Den_dk_07.webm','\\- Дэн, только пожалуйста не туда, ну ты понимаешь...// - вы непроизвольно опускаете глаза
\\\- Не туда это куда? В попец что ли?/// - хохотнул Дэн \\\- целку бережешь? Ладно... Пойду на встречу.///'
					dynamic $analsex
					gs 'zz_render','','','Внезапно Дэн вынимает свой член.**\\\- Ну ка быстро, открой ротик, ну-ну... А-а-а-а...///'
					act 'Принять в рот':
						*clr & cla
						gs 'zz_render','','pavlovo/dk/disco/dk_toilet/Den_dk_05.webm','Струя теплой спермы бьет вам в рот.**\\\- Все заглатывай, не трусами же мне вытирать, - говорит Дэн.///'
						act 'Чистить':
						*clr & cla
						if $npc['10,sex'] = 0: $npc['10,sex'] = 1 & guy += 1
						bj += 1
						if throat < dick: throat += 1
						gs 'zz_funcs', 'cum', 'face'
						minut += 10
						gs 'stat'
						gs 'zz_render','','pavlovo/dk/disco/dk_toilet/Den_dk_06.webm','Не желая спорить, вы досуха высасываете остатки спермы из его члена. После того, как Дэн ушел, вы идете к умывальнику и приводите себя в порядок.'
							act 'Привести себя в порядок': gt 'zz_toilet'
						end
					end
				end
			end
		end
	end
	act 'Отказать':
		*clr & cla
		dom += 1
		gs 'zz_reputation','set',2
		gs 'stat'
		gs 'zz_render','','pavlovo/dk/disco/dk_toilet/Den_dk_08.webm','\\- Да пошел бы ты...// - вы возмущенно отталкиваете Дэна.
\\\- Уверенна?/// - Дэн с прищуром смотрит на вас \\\- посмотрим что ты запоешь завтра.///
\\- Посмотрим// - словно какой то черт дергает вас за язык \\- давай, попробуй!//
Нагло ухмыльнувшийсь, парень бросил недокуренную сигарету в угол, и оставил вас в одиночистве.!
Вас все еще немного трясет. Кажется только что вы совершили ошибку. Пытаясь успокоится, вы спокойно допиваете пиво.'
		act 'Уйти': gt 'gdkin'
	end
else
	gs 'zz_render','','pavlovo/dk/disco/dk_toilet/Den_dk_01.webm','Распарившись после очередного танца вы заходите в туалет, чтобы привести себя в порядок, покурить и промочить горло остатками пива - бурные пляски вызывают бурную жажду.
Случайно или нет, но следом за вами в туалет заходит Дэн и, внимательно вас оглядев, проходит к толчку.
Закончив свои дела, Дэн подошел к вам и, угостив сигареткой, завязал пустой разговор ни о чем.
Какое-то время вы болтали, пока, наконец, до вас не дошло, что для Дэна разговор был совсем не пустой: опустив глаза, вы поняли, что он имеет вполне определенные намерения и полностью готов их осуществить - его член прям-таки рвался из штанов.
\\\- Ладно, <<$name[1]>>, не тяни кота за хвост, отсоси мне по-быстрому, и пойдем в зал, пока эти жлобы все пиво не вылакали.///'
	act 'Подчиниться':
		*clr & cla
		dom -= 1
		gs 'zz_render','','pavlovo/dk/disco/dk_toilet/Den_dk_02.webm','Понимая, что деваться вам некуда и что молчание Дэна - единственная гарантия того, что вы не пойдете в Павлово по рукам… ну, не совсем по рукам, блин, даже думать об этом не хочется, вы встали на колени, расстегнули Дэну ширинку и достали его член.'
		act 'Ласкать ртом':
			*clr & cla
			dom -= 1
			horny += 10
			gs 'stat'
			gs 'zz_render','','pavlovo/dk/disco/dk_toilet/Den_dk_03.webm','\\\- Ну, чего смотришь? Облизни его.///
Пару минут вы обрабатываете член Дэна, проводя язычком по всей его длине, лижете яйца и снова член.
\\\- А теперь давай, ручками-губками, все как ты умеешь/// - Дэн ухмыляется. Вас бесит его ухмылка, но вы покорно выполняете наглое требование парня.'
			act 'Сосать':
				*clr & cla
				gs 'zz_render','','pavlovo/dk/disco/dk_toilet/Den_dk_04.webm','Поработав ртом и руками несколько минут, вы чувствуете, что Дэн вот-вот кончит. Еще несколько движений, еще…
"Ну давай же - думаете вы про себя, ну..."
\\\-Стой - Дэн тяжело дышит - повернись-ка попкой...///'
				act 'Продолжить сосать':
					*clr & cla
					gs 'zz_render','','pavlovo/dk/disco/dk_toilet/Den_dk_05.webm','В ответ вы только замычали что то непонятное и лишь удвоили свои старания.
\\\-А-а-а-а.../// - Дэн разрядился вам в рот.
\\\- Черт, возьми, какого хрена? Хотя так тоже не плохо.///
\\\-Все заглатывай, не трусами же мне вытирать///, - говорит Дэн.'
					act 'Чистить':
						*clr & cla
						if $npc['10,sex'] = 0: $npc['10,sex'] = 1 & guy += 1
						bj += 1
						if throat < dick: throat += 1
						gs 'zz_funcs', 'cum', 'face'
						minut += 10
						gs 'stat'
						gs 'zz_render','','pavlovo/dk/disco/dk_toilet/Den_dk_06.webm','Не желая спорить, вы досуха высасываете остатки спермы из его члена. После того, как Дэн ушел, вы идете к умывальнику и приводите себя в порядок.'
						act 'Привести себя в порядок': gt 'zz_toilet'
					end
				end
				act 'Уговаривать':
					*clr & cla
					horny += 10
					gs 'stat'
					gs 'zz_render','','pavlovo/dk/disco/dk_toilet/Den_dk_09.webm','\\- Дэн, ну пожалуйста не надо// - просите вы стараясь не встречаться глазами с Дэном.
\\\- Это еще почему? Ты ж не девочка? Иди ка сюда.///
\\- Ну Дэн! Ну пожалуйста...// - вы пытаетесь убрать руки парня.
Дэн старается поцеловать вас, но вы отворачиваетесь, пытаясь вырваться из объятий Дэна, но тот целуя вас в щеку обнажает вам грудь.
\\- Ну Дэн!!!// - в вашем голосе слышатся истеричные нотки.
\\\- Да ладно, тебе что жалко?///'
					act 'Наклониться':
						*clr & cla
						gs 'zz_render','','pavlovo/dk/disco/dk_toilet/Den_dk_10.webm','\\\- Ну-ка раком встала!/// - ошалев от неожиданного предложения вы нагибаетесь.
\\\-Вот так, а то целочку тут разъигрывала///, - говорит Дэн.
\\- Ой! Ты все же поосторожнее...// - но осекаетесь, понимая что Дэну сейчас плевать на ваши слова.'
						dynamic $sexstar2
						act 'Попросить':
							*clr & cla
							gs 'zz_render','','pavlovo/dk/disco/dk_toilet/Den_dk_12.webm','\\\- Чёта я кончить никак не могу/// - притормаживает он.
\\\- Ща по другому попробуем!/// - Дэн ставит вас на четвереньки и пальцем принимается разрабатывать анус.
\\- Эй, ну не насухо же! Ну Дэ-э-эн...// - просительно тянете вы.'
							act 'Наслаждаться':
								*clr & cla
								horny += 10
								gs 'stat'
								gs 'zz_render','','pavlovo/dk/disco/dk_toilet/Den_dk_11.webm','\\\- Хрен с тобой, уговорила. Только не ной, сейчас все сделаю, как королеве, но если вспизднешь кому, прибью к херам, ясно?/// - с этими словами Дэн наклоняется к вашей заднице.
\\- Ох//, - срывается с ваших губ \\- Дэн, ты...//
\\\- Просто молчи, поняла?/// - Дэн продолжает лизать вам анус.
Вы молча киваете головой.'
								act 'Дать':
									*clr & cla
									gs 'zz_render','','pavlovo/dk/disco/dk_toilet/Den_dk_13.webm','\\\- Ага, отлично, щас потуже пойдёт!///'
									gs 'zz_dynamic_sex', 'anal_start', 'dick'
									gs 'zz_dynamic_sex', 'anal', 'dick'
									act 'Сменить позицию':
										*clr & cla
										gs 'zz_render','','pavlovo/dk/disco/dk_toilet/Den_dk_14.webm','\\\- Так, а теперь давай сверху/// - командует Дэн.
\\- Так?// - спрашиваете вы - \\или может быть...//
\\\- Так, так, давай двигайся!///'
										act 'Сменить позицию':
											*clr & cla
											gs 'zz_render','','pavlovo/dk/disco/dk_toilet/Den_dk_15.webm','\\\- А теперь встань. Да встань говорю, прогнись, вот так - Дэн заставляет вас встать и выгнуть спину.///'
											act 'Терпеть':
												*clr & cla
												gs 'zz_render','','pavlovo/dk/disco/dk_toilet/Den_dk_16.webm','\\\- Стой, я сейчас, замри/// - вы покорно замираете и чувстуете как струя спермы бьет в вашу попку.
\\- О да, ты супер.//
Дэн достает член из вашей задницы. Вы пытаетесь поправить одежду, но ден резко берет вас за волосы.
\\\- Эй, а чистить кто будет? Не трусами же мне вытирать///, - говорит Дэн.'
												act 'Чистить':
													*clr & cla
													if $npc['10,sex'] = 0: $npc['10,sex'] = 1 & guy += 1
													bj += 1
													if throat < dick: throat += 1
													gs 'zz_funcs', 'cum', 'lip'
													gs 'zz_funcs', 'cum', 'anus'
													minut += 10
													gs 'stat'
													gs 'zz_render','','pavlovo/dk/disco/dk_toilet/Den_dk_06.webm','Не желая спорить, вы досуха высасываете остатки спермы из его члена. После того, как Дэн ушел, вы идете к умывальнику и приводите себя в порядок.'
													act 'Привести себя в порядок': gt 'zz_toilet'
												end
											end
										end
									end
								end
							end
						end
					end
				end
			end
		end
	end
	act 'Отказать':
		*clr & cla
		dom += 1
		gs 'zz_reputation','set',2
		gs 'stat'
		gs 'zz_render','','pavlovo/dk/disco/dk_toilet/Den_dk_08.webm','\\- Да пошел бы ты...// - вы возмущенно отталкиваете Дэна.
\\\- Уверенна?/// - Дэн с прищуром смотрит на вас \\\- посмотрим что ты запоешь завтра.///
\\- Посмотрим// - словно какой то черт дергает вас за язык \\- давай, попробуй!//
Нагло ухмыльнувшийсь, парень бросил недокуренную сигарету в угол, и оставил вас в одиночистве.!
Вас все еще немного трясет. Кажется только что вы совершили ошибку. Пытаясь успокоится, вы спокойно допиваете пиво.'
		act 'Уйти': gt 'gdkin'
	end
end