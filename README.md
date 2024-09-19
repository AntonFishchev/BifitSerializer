# BifitSerializer

## Результат работы программы

Исходный документ Bifir:

$DOCUMENT
DOC_TYPE=open_account_contract
DOC_ID=123123
$OWNER
CLIENT_ID=1212
EXT_CLIENT_ID=1231233
$OWNER_END
$CONTENT
CLIENT_COMMENT=
CURRENCY=RUR
AGREEMENT_TEXT=Согласен
NUM_DOC=1
ISO_CURRENCY=RUR
IDCARD_SERIAL=1212
CLN_INN=321346456456
IDCARD_ISSUE_DATE=01.02.2002
AGREEMENT=1
CLN_BIRTHDATE=15.08.1986
CURRENCY_CODE=810
IDCARD_ISSUER=20 ОТДЕЛОМ МИЛИЦИИ
MAKE_TRANSFER=0
BANK_BIC=123123123
DATE_DOC=28.08.2024
CLN_FACTADDR=Российская Федерация, 140105, Московская обл, г. Пас, Ленина ул, д. 16, кв. 54
CLN_PHONECELL=+79263451183
IDCARD_TYPE=Паспорт гражданина РФ
ACCOUNT_TYPE_NAME=Текущий -- Накопительный
IDCARD_NUMBER=129297
CLN_FIO=Иванов Иван Иванович
CLN_REGADDR=Российская Федерация, 140105, Московская обл, г. Пас, Ленина ул, д. 16, кв. 54
BANK_NAME=ООО г. Москва
$CONTENT_END
$SIGN
TIMESTAMP=28.08.2024 11:11:11.000
ID_KEY=656565656465656
GROUP=0
OWNER=Иванов Иван Иванович
OWNER_POSITION=
HW_TOKEN=
SIGN_TYPE=SMS
$SIGN_END
$AUXILIARY_SECTION
REMOTE_IP_ADDRESS=192.168.123.12
$AUXILIARY_SECTION_END
$DOCUMENT_END

----------

Спаршенный JSON из исходногого документа:

{
  "$DOCUMENT": {
    "DOC_TYPE": "open_account_contract",
    "DOC_ID": "123123",
    "$OWNER": {
      "CLIENT_ID": "1212",
      "EXT_CLIENT_ID": "1231233"
    },
    "$CONTENT": {
      "CLIENT_COMMENT": "",
      "CURRENCY": "RUR",
      "AGREEMENT_TEXT": "Согласен",
      "NUM_DOC": "1",
      "ISO_CURRENCY": "RUR",
      "IDCARD_SERIAL": "1212",
      "CLN_INN": "321346456456",
      "IDCARD_ISSUE_DATE": "01.02.2002",
      "AGREEMENT": "1",
      "CLN_BIRTHDATE": "15.08.1986",
      "CURRENCY_CODE": "810",
      "IDCARD_ISSUER": "20 ОТДЕЛОМ МИЛИЦИИ",
      "MAKE_TRANSFER": "0",
      "BANK_BIC": "123123123",
      "DATE_DOC": "28.08.2024",
      "CLN_FACTADDR": "Российская Федерация, 140105, Московская обл, г. Пас, Ленина ул, д. 16, кв. 54",
      "CLN_PHONECELL": "+79263451183",
      "IDCARD_TYPE": "Паспорт гражданина РФ",
      "ACCOUNT_TYPE_NAME": "Текущий -- Накопительный",
      "IDCARD_NUMBER": "129297",
      "CLN_FIO": "Иванов Иван Иванович",
      "CLN_REGADDR": "Российская Федерация, 140105, Московская обл, г. Пас, Ленина ул, д. 16, кв. 54",
      "BANK_NAME": "ООО г. Москва"
    },
    "$SIGN": {
      "TIMESTAMP": "28.08.2024 11:11:11.000",
      "ID_KEY": "656565656465656",
      "GROUP": "0",
      "OWNER": "Иванов Иван Иванович",
      "OWNER_POSITION": "",
      "HW_TOKEN": "",
      "SIGN_TYPE": "SMS"
    },
    "$AUXILIARY_SECTION": {
      "REMOTE_IP_ADDRESS": "192.168.123.12"
    }
  }
}

----------

Десериализованный и сериализованный спаршенный JSON:

{
  "$DOCUMENT": {
    "DOC_TYPE": "open_account_contract",
    "DOC_ID": 123123,
    "$OWNER": {
      "CLIENT_ID": 1212,
      "EXT_CLIENT_ID": 1231233
    },
    "$CONTENT": {
      "CLIENT_COMMENT": "",
      "CURRENCY": "RUR",
      "AGREEMENT_TEXT": "Согласен",
      "NUM_DOC": 1,
      "ISO_CURRENCY": "RUR",
      "IDCARD_SERIAL": "1212",
      "CLN_INN": "321346456456",
      "IDCARD_ISSUE_DATE": "01.02.2002",
      "AGREEMENT": 1,
      "CLN_BIRTHDATE": "15.08.1986",
      "CURRENCY_CODE": 810,
      "IDCARD_ISSUER": "20 ОТДЕЛОМ МИЛИЦИИ",
      "MAKE_TRANSFER": 0,
      "BANK_BIC": "123123123",
      "DATE_DOC": "28.08.2024",
      "CLN_FACTADDR": "Российская Федерация, 140105, Московская обл, г. Пас, Ленина ул, д. 16, кв. 54",
      "CLN_PHONECELL": "+79263451183",
      "IDCARD_TYPE": "Паспорт гражданина РФ",
      "ACCOUNT_TYPE_NAME": "Текущий -- Накопительный",
      "IDCARD_NUMBER": "129297",
      "CLN_FIO": "Иванов Иван Иванович",
      "CLN_REGADDR": "Российская Федерация, 140105, Московская обл, г. Пас, Ленина ул, д. 16, кв. 54",
      "BANK_NAME": "ООО г. Москва"
    },
    "$SIGN": {
      "TIMESTAMP": "28.08.2024 11:11:11.000",
      "ID_KEY": "656565656465656",
      "GROUP": 0,
      "OWNER": "Иванов Иван Иванович",
      "OWNER_POSITION": "",
      "HW_TOKEN": "",
      "SIGN_TYPE": "SMS"
    },
    "$AUXILIARY_SECTION": {
      "REMOTE_IP_ADDRESS": "192.168.123.12"
    }
  }
}

----------

Спаршенный Bifir из предыдущего JSON:

$DOCUMENT
DOC_TYPE=open_account_contract
DOC_ID=123123
$OWNER
CLIENT_ID=1212
EXT_CLIENT_ID=1231233
$OWNER_END
$CONTENT
CLIENT_COMMENT=
CURRENCY=RUR
AGREEMENT_TEXT=Согласен
NUM_DOC=1
ISO_CURRENCY=RUR
IDCARD_SERIAL=1212
CLN_INN=321346456456
IDCARD_ISSUE_DATE=01.02.2002
AGREEMENT=1
CLN_BIRTHDATE=15.08.1986
CURRENCY_CODE=810
IDCARD_ISSUER=20 ОТДЕЛОМ МИЛИЦИИ
MAKE_TRANSFER=0
BANK_BIC=123123123
DATE_DOC=28.08.2024
CLN_FACTADDR=Российская Федерация, 140105, Московская обл, г. Пас, Ленина ул, д. 16, кв. 54
CLN_PHONECELL=+79263451183
IDCARD_TYPE=Паспорт гражданина РФ
ACCOUNT_TYPE_NAME=Текущий -- Накопительный
IDCARD_NUMBER=129297
CLN_FIO=Иванов Иван Иванович
CLN_REGADDR=Российская Федерация, 140105, Московская обл, г. Пас, Ленина ул, д. 16, кв. 54
BANK_NAME=ООО г. Москва
$CONTENT_END
$SIGN
TIMESTAMP=28.08.2024 11:11:11.000
ID_KEY=656565656465656
GROUP=0
OWNER=Иванов Иван Иванович
OWNER_POSITION=
HW_TOKEN=
SIGN_TYPE=SMS
$SIGN_END
$AUXILIARY_SECTION
REMOTE_IP_ADDRESS=192.168.123.12
$AUXILIARY_SECTION_END
$DOCUMENT_END
