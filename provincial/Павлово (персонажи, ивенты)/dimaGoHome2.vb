﻿gs'stat'
if dimaGohomeday = day:
	gs 'zz_render', '', '', 'Вы подошли к красивому частному дому и позвонили в звонок. Вам открыла дверь симпатичная блондинка лет около сорока, видимо мать Димы. Она посмотрела на вас и улыбнулась:**\\\- Димы нет дома.///'
	act 'Уйти': gt'gorodok'
else
	gs 'zz_render', '', '', 'Вы подошли к красивому частному дому и позвонили в звонок. Вам открыла дверь симпатичная блондинка лет около сорока, видимо мать Димы. Она посмотрела на вас и улыбнулась:**\\\- Вы к Диме?///**Вы утвердительно кивнули головой и мать Димы впустила вас в дом.'
	act 'Идти в комнату Димы': dimaGohomeday = day & gt'dimaHome'
end