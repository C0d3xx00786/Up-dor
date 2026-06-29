CREATE TABLE [dbo].[drugs] (
    [barcode]             VARCHAR (20)   NOT NULL,
    [name]                NVARCHAR (255) COLLATE Cyrillic_General_CI_AS NOT NULL,
    [measurement_unit]    NVARCHAR (20)  COLLATE Cyrillic_General_CI_AS NOT NULL,
    [quantity_per_pack]   INT            NOT NULL,
    [manufacturer]        NVARCHAR (255) COLLATE Cyrillic_General_CI_AS NULL,
    [need_recipe]         BIT            NULL,
    [pharmacologic_group] NVARCHAR (255) COLLATE Cyrillic_General_CI_AS NULL,
    [is_narcotic]         BIT            NULL,
    [is_vital]            BIT            NULL,
    [storage_location]    NVARCHAR (100) COLLATE Cyrillic_General_CI_AS NULL,
    PRIMARY KEY CLUSTERED ([barcode] ASC)
);
GO

CREATE TABLE [dbo].[drug_items] (
    [uid]                NVARCHAR (20)   COLLATE Cyrillic_General_CI_AS NOT NULL,
    [barcode]            VARCHAR (20)    NOT NULL,
    [purchase_price]     DECIMAL (10, 2) NULL,
    [retail_price]       DECIMAL (10, 2) NULL,
    [expiration_date]    DATE            NOT NULL,
    [receipt_date]       DATE            DEFAULT (getdate()) NULL,
    [item_status]        NVARCHAR (20)   COLLATE Cyrillic_General_CI_AS DEFAULT (N'in_stock') NULL,
    [written_off_reason] NVARCHAR (MAX)  COLLATE Cyrillic_General_CI_AS NULL,
    [supplier_batch]     NVARCHAR (100)  COLLATE Cyrillic_General_CI_AS NULL,
    PRIMARY KEY CLUSTERED ([uid] ASC),
    FOREIGN KEY ([barcode]) REFERENCES [dbo].[drugs] ([barcode])
);
GO

CREATE TABLE [dbo].[complaints] (
    [Id]             INT            IDENTITY (1, 1) NOT NULL,
    [Uid]            NVARCHAR (20)  COLLATE Cyrillic_General_CI_AS NOT NULL,
    [DrugName]       NVARCHAR (200) NOT NULL,
    [DoctorName]     NVARCHAR (100) NULL,
    [RecipeDetails]  NVARCHAR (200) NULL,
    [PatientName]    NVARCHAR (100) NULL,
    [PatientContact] NVARCHAR (100) NULL,
    [Comment]        NVARCHAR (500) NULL,
    [ComplaintDate]  DATETIME       NOT NULL,
    [Status]         NVARCHAR (20)  NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY ([Uid]) REFERENCES [dbo].[drug_items] ([uid])
);
GO

CREATE TABLE [dbo].[sales_history] (
    [sale_id]    INT             IDENTITY (1, 1) NOT NULL,
    [uid]        NVARCHAR (20)   COLLATE Cyrillic_General_CI_AS NOT NULL,
    [sale_date]  DATETIME        NOT NULL,
    [sold_price] DECIMAL (10, 2) NOT NULL,
    PRIMARY KEY CLUSTERED ([sale_id] ASC),
    CONSTRAINT [fk_sales_history_uid] FOREIGN KEY ([uid]) REFERENCES [dbo].[drug_items] ([uid]) ON DELETE CASCADE
);
GO

INSERT INTO [dbo].[drugs] ([barcode], [name], [measurement_unit], [quantity_per_pack], [manufacturer], [need_recipe], [pharmacologic_group], [is_narcotic], [is_vital], [storage_location]) VALUES (N'4601234567001', N'Анальгин', N'таблетки', 10, N'Фармстандарт', 0, N'Анальгетики', 0, 1, N'Витрина')
INSERT INTO [dbo].[drugs] ([barcode], [name], [measurement_unit], [quantity_per_pack], [manufacturer], [need_recipe], [pharmacologic_group], [is_narcotic], [is_vital], [storage_location]) VALUES (N'4601234567002', N'Ибупрофен', N'таблетки', 20, N'Биосинтез', 0, N'НПВС', 0, 1, N'Витрина')
INSERT INTO [dbo].[drugs] ([barcode], [name], [measurement_unit], [quantity_per_pack], [manufacturer], [need_recipe], [pharmacologic_group], [is_narcotic], [is_vital], [storage_location]) VALUES (N'4601234567003', N'Парацетамол', N'таблетки', 20, N'Фармстандарт', 0, N'Анальгетики', 0, 1, N'Витрина')
INSERT INTO [dbo].[drugs] ([barcode], [name], [measurement_unit], [quantity_per_pack], [manufacturer], [need_recipe], [pharmacologic_group], [is_narcotic], [is_vital], [storage_location]) VALUES (N'4601234567004', N'Кеторол', N'ампулы', 10, N'Д-р Реддис', 1, N'НПВС', 0, 0, N'Холодильник')
INSERT INTO [dbo].[drugs] ([barcode], [name], [measurement_unit], [quantity_per_pack], [manufacturer], [need_recipe], [pharmacologic_group], [is_narcotic], [is_vital], [storage_location]) VALUES (N'4601234567005', N'Диклофенак', N'таблетки', 20, N'Хемофарм', 0, N'НПВС', 0, 1, N'Шкаф')
INSERT INTO [dbo].[drugs] ([barcode], [name], [measurement_unit], [quantity_per_pack], [manufacturer], [need_recipe], [pharmacologic_group], [is_narcotic], [is_vital], [storage_location]) VALUES (N'4601234567006', N'Амоксициллин', N'капсулы', 16, N'Сандоз', 1, N'Антибиотики', 0, 1, N'Холодильник')
INSERT INTO [dbo].[drugs] ([barcode], [name], [measurement_unit], [quantity_per_pack], [manufacturer], [need_recipe], [pharmacologic_group], [is_narcotic], [is_vital], [storage_location]) VALUES (N'4601234567007', N'Азитромицин', N'капсулы', 6, N'Плива', 1, N'Антибиотики', 0, 1, N'Холодильник')
INSERT INTO [dbo].[drugs] ([barcode], [name], [measurement_unit], [quantity_per_pack], [manufacturer], [need_recipe], [pharmacologic_group], [is_narcotic], [is_vital], [storage_location]) VALUES (N'4601234567008', N'Цефтриаксон', N'флаконы', 1, N'Красфарма', 1, N'Антибиотики', 0, 1, N'Холодильник')
INSERT INTO [dbo].[drugs] ([barcode], [name], [measurement_unit], [quantity_per_pack], [manufacturer], [need_recipe], [pharmacologic_group], [is_narcotic], [is_vital], [storage_location]) VALUES (N'4601234567009', N'Ципрофлоксацин', N'таблетки', 10, N'Байер', 1, N'Антибиотики', 0, 0, N'Холодильник')
INSERT INTO [dbo].[drugs] ([barcode], [name], [measurement_unit], [quantity_per_pack], [manufacturer], [need_recipe], [pharmacologic_group], [is_narcotic], [is_vital], [storage_location]) VALUES (N'4601234567010', N'Доксициклин', N'капсулы', 10, N'Биосинтез', 1, N'Антибиотики', 0, 0, N'Холодильник')
INSERT INTO [dbo].[drugs] ([barcode], [name], [measurement_unit], [quantity_per_pack], [manufacturer], [need_recipe], [pharmacologic_group], [is_narcotic], [is_vital], [storage_location]) VALUES (N'4601234567011', N'Каптоприл', N'таблетки', 40, N'Акрихин', 1, N'Ингибиторы АПФ', 0, 1, N'Шкаф')
INSERT INTO [dbo].[drugs] ([barcode], [name], [measurement_unit], [quantity_per_pack], [manufacturer], [need_recipe], [pharmacologic_group], [is_narcotic], [is_vital], [storage_location]) VALUES (N'4601234567012', N'Эналаприл', N'таблетки', 20, N'Гедеон Рихтер', 1, N'Ингибиторы АПФ', 0, 1, N'Шкаф')
INSERT INTO [dbo].[drugs] ([barcode], [name], [measurement_unit], [quantity_per_pack], [manufacturer], [need_recipe], [pharmacologic_group], [is_narcotic], [is_vital], [storage_location]) VALUES (N'4601234567013', N'Бисопролол', N'таблетки', 30, N'Нижфарм', 1, N'Бета-блокаторы', 0, 1, N'Шкаф')
INSERT INTO [dbo].[drugs] ([barcode], [name], [measurement_unit], [quantity_per_pack], [manufacturer], [need_recipe], [pharmacologic_group], [is_narcotic], [is_vital], [storage_location]) VALUES (N'4601234567014', N'Амлодипин', N'таблетки', 30, N'Пфайзер', 1, N'Блокаторы кальциевых каналов', 0, 1, N'Шкаф')
INSERT INTO [dbo].[drugs] ([barcode], [name], [measurement_unit], [quantity_per_pack], [manufacturer], [need_recipe], [pharmacologic_group], [is_narcotic], [is_vital], [storage_location]) VALUES (N'4601234567015', N'Валидол', N'таблетки', 10, N'Фармстандарт', 0, N'Коронародилататоры', 0, 0, N'Витрина')
INSERT INTO [dbo].[drugs] ([barcode], [name], [measurement_unit], [quantity_per_pack], [manufacturer], [need_recipe], [pharmacologic_group], [is_narcotic], [is_vital], [storage_location]) VALUES (N'4601234567016', N'Омепразол', N'капсулы', 30, N'КРКА', 0, N'Ингибиторы протонной помпы', 0, 1, N'Шкаф')
INSERT INTO [dbo].[drugs] ([barcode], [name], [measurement_unit], [quantity_per_pack], [manufacturer], [need_recipe], [pharmacologic_group], [is_narcotic], [is_vital], [storage_location]) VALUES (N'4601234567017', N'Панкреатин', N'таблетки', 60, N'Биосинтез', 0, N'Ферменты', 0, 0, N'Стеллаж')
INSERT INTO [dbo].[drugs] ([barcode], [name], [measurement_unit], [quantity_per_pack], [manufacturer], [need_recipe], [pharmacologic_group], [is_narcotic], [is_vital], [storage_location]) VALUES (N'4601234567018', N'Смекта', N'пакетики', 10, N'Ипсен Фарма', 0, N'Адсорбенты', 0, 0, N'Витрина')
INSERT INTO [dbo].[drugs] ([barcode], [name], [measurement_unit], [quantity_per_pack], [manufacturer], [need_recipe], [pharmacologic_group], [is_narcotic], [is_vital], [storage_location]) VALUES (N'4601234567019', N'Эспумизан', N'капсулы', 25, N'Берлин-Хеми', 0, N'Ветрогонные', 0, 0, N'Шкаф')
INSERT INTO [dbo].[drugs] ([barcode], [name], [measurement_unit], [quantity_per_pack], [manufacturer], [need_recipe], [pharmacologic_group], [is_narcotic], [is_vital], [storage_location]) VALUES (N'4601234567020', N'Лоперамид', N'капсулы', 20, N'Оболенское', 0, N'Противодиарейные', 0, 1, N'Шкаф')
INSERT INTO [dbo].[drugs] ([barcode], [name], [measurement_unit], [quantity_per_pack], [manufacturer], [need_recipe], [pharmacologic_group], [is_narcotic], [is_vital], [storage_location]) VALUES (N'4601234567021', N'Супрастин', N'таблетки', 20, N'Эгис', 0, N'Антигистаминные', 0, 0, N'Витрина')
INSERT INTO [dbo].[drugs] ([barcode], [name], [measurement_unit], [quantity_per_pack], [manufacturer], [need_recipe], [pharmacologic_group], [is_narcotic], [is_vital], [storage_location]) VALUES (N'4601234567022', N'Цетрин', N'таблетки', 20, N'Д-р Реддис', 0, N'Антигистаминные', 0, 0, N'Витрина')
INSERT INTO [dbo].[drugs] ([barcode], [name], [measurement_unit], [quantity_per_pack], [manufacturer], [need_recipe], [pharmacologic_group], [is_narcotic], [is_vital], [storage_location]) VALUES (N'4601234567023', N'Кларитин', N'сироп', 1, N'Шеринг-Плау', 0, N'Антигистаминные', 0, 0, N'Холодильник')
INSERT INTO [dbo].[drugs] ([barcode], [name], [measurement_unit], [quantity_per_pack], [manufacturer], [need_recipe], [pharmacologic_group], [is_narcotic], [is_vital], [storage_location]) VALUES (N'4601234567024', N'Зодак', N'капли', 1, N'Зентива', 0, N'Антигистаминные', 0, 0, N'Холодильник')
INSERT INTO [dbo].[drugs] ([barcode], [name], [measurement_unit], [quantity_per_pack], [manufacturer], [need_recipe], [pharmacologic_group], [is_narcotic], [is_vital], [storage_location]) VALUES (N'4601234567025', N'Тавегил', N'ампулы', 5, N'Новартис', 1, N'Антигистаминные', 0, 0, N'Холодильник')
INSERT INTO [dbo].[drugs] ([barcode], [name], [measurement_unit], [quantity_per_pack], [manufacturer], [need_recipe], [pharmacologic_group], [is_narcotic], [is_vital], [storage_location]) VALUES (N'4601234567026', N'Аскорбиновая кислота', N'таблетки', 200, N'Фармстандарт', 0, N'Витамины', 0, 0, N'Стеллаж')
INSERT INTO [dbo].[drugs] ([barcode], [name], [measurement_unit], [quantity_per_pack], [manufacturer], [need_recipe], [pharmacologic_group], [is_narcotic], [is_vital], [storage_location]) VALUES (N'4601234567027', N'Витамин Д3', N'капсулы', 60, N'Эвалар', 0, N'Витамины', 0, 0, N'Стеллаж')
INSERT INTO [dbo].[drugs] ([barcode], [name], [measurement_unit], [quantity_per_pack], [manufacturer], [need_recipe], [pharmacologic_group], [is_narcotic], [is_vital], [storage_location]) VALUES (N'4601234567028', N'Компливит', N'таблетки', 60, N'Фармстандарт', 0, N'Витамины', 0, 0, N'Стеллаж')
INSERT INTO [dbo].[drugs] ([barcode], [name], [measurement_unit], [quantity_per_pack], [manufacturer], [need_recipe], [pharmacologic_group], [is_narcotic], [is_vital], [storage_location]) VALUES (N'4601234567029', N'Магне В6', N'таблетки', 50, N'Санофи', 0, N'Минералы', 0, 0, N'Стеллаж')
INSERT INTO [dbo].[drugs] ([barcode], [name], [measurement_unit], [quantity_per_pack], [manufacturer], [need_recipe], [pharmacologic_group], [is_narcotic], [is_vital], [storage_location]) VALUES (N'4601234567030', N'Рыбий жир', N'капсулы', 100, N'Эвалар', 0, N'БАДы', 0, 0, N'Холодильник')
INSERT INTO [dbo].[drugs] ([barcode], [name], [measurement_unit], [quantity_per_pack], [manufacturer], [need_recipe], [pharmacologic_group], [is_narcotic], [is_vital], [storage_location]) VALUES (N'4601234567031', N'Глицин', N'таблетки', 50, N'Биотики', 0, N'Ноотропы', 0, 0, N'Витрина')
INSERT INTO [dbo].[drugs] ([barcode], [name], [measurement_unit], [quantity_per_pack], [manufacturer], [need_recipe], [pharmacologic_group], [is_narcotic], [is_vital], [storage_location]) VALUES (N'4601234567032', N'Феназепам', N'таблетки', 50, N'Валента', 1, N'Транквилизаторы', 1, 0, N'Сейф')
INSERT INTO [dbo].[drugs] ([barcode], [name], [measurement_unit], [quantity_per_pack], [manufacturer], [need_recipe], [pharmacologic_group], [is_narcotic], [is_vital], [storage_location]) VALUES (N'4601234567033', N'Афобазол', N'таблетки', 60, N'Фармстандарт', 0, N'Анксиолитики', 0, 0, N'Шкаф')
INSERT INTO [dbo].[drugs] ([barcode], [name], [measurement_unit], [quantity_per_pack], [manufacturer], [need_recipe], [pharmacologic_group], [is_narcotic], [is_vital], [storage_location]) VALUES (N'4601234567034', N'Новопассит', N'сироп', 1, N'Тева', 0, N'Седативные', 0, 0, N'Шкаф')
INSERT INTO [dbo].[drugs] ([barcode], [name], [measurement_unit], [quantity_per_pack], [manufacturer], [need_recipe], [pharmacologic_group], [is_narcotic], [is_vital], [storage_location]) VALUES (N'4601234567035', N'Фенибут', N'таблетки', 20, N'Белмедпрепараты', 1, N'Ноотропы', 0, 0, N'Сейф')
INSERT INTO [dbo].[drugs] ([barcode], [name], [measurement_unit], [quantity_per_pack], [manufacturer], [need_recipe], [pharmacologic_group], [is_narcotic], [is_vital], [storage_location]) VALUES (N'4601234567036', N'Бромгексин', N'таблетки', 20, N'Биосинтез', 0, N'Муколитики', 0, 0, N'Шкаф')
INSERT INTO [dbo].[drugs] ([barcode], [name], [measurement_unit], [quantity_per_pack], [manufacturer], [need_recipe], [pharmacologic_group], [is_narcotic], [is_vital], [storage_location]) VALUES (N'4601234567037', N'Амброксол', N'сироп', 1, N'КРКА', 0, N'Муколитики', 0, 0, N'Шкаф')
INSERT INTO [dbo].[drugs] ([barcode], [name], [measurement_unit], [quantity_per_pack], [manufacturer], [need_recipe], [pharmacologic_group], [is_narcotic], [is_vital], [storage_location]) VALUES (N'4601234567038', N'АЦЦ', N'пакетики', 20, N'Сандоз', 0, N'Муколитики', 0, 0, N'Витрина')
INSERT INTO [dbo].[drugs] ([barcode], [name], [measurement_unit], [quantity_per_pack], [manufacturer], [need_recipe], [pharmacologic_group], [is_narcotic], [is_vital], [storage_location]) VALUES (N'4601234567039', N'Ингалипт', N'спрей', 1, N'Фармстандарт', 0, N'Антисептики', 0, 0, N'Витрина')
INSERT INTO [dbo].[drugs] ([barcode], [name], [measurement_unit], [quantity_per_pack], [manufacturer], [need_recipe], [pharmacologic_group], [is_narcotic], [is_vital], [storage_location]) VALUES (N'4601234567040', N'Мукалтин', N'таблетки', 30, N'Уралбиофарм', 0, N'Отхаркивающие', 0, 0, N'Шкаф')
INSERT INTO [dbo].[drugs] ([barcode], [name], [measurement_unit], [quantity_per_pack], [manufacturer], [need_recipe], [pharmacologic_group], [is_narcotic], [is_vital], [storage_location]) VALUES (N'4601234567041', N'Преднизолон', N'ампулы', 3, N'Никомед', 1, N'Глюкокортикостероиды', 0, 1, N'Холодильник')
INSERT INTO [dbo].[drugs] ([barcode], [name], [measurement_unit], [quantity_per_pack], [manufacturer], [need_recipe], [pharmacologic_group], [is_narcotic], [is_vital], [storage_location]) VALUES (N'4601234567042', N'Дексаметазон', N'ампулы', 10, N'КРКА', 1, N'Глюкокортикостероиды', 0, 1, N'Холодильник')
INSERT INTO [dbo].[drugs] ([barcode], [name], [measurement_unit], [quantity_per_pack], [manufacturer], [need_recipe], [pharmacologic_group], [is_narcotic], [is_vital], [storage_location]) VALUES (N'4601234567043', N'L-тироксин', N'таблетки', 100, N'Берлин-Хеми', 1, N'Тиреоидные', 0, 1, N'Холодильник')
INSERT INTO [dbo].[drugs] ([barcode], [name], [measurement_unit], [quantity_per_pack], [manufacturer], [need_recipe], [pharmacologic_group], [is_narcotic], [is_vital], [storage_location]) VALUES (N'4601234567044', N'Левомеколь', N'туба', 1, N'Нижфарм', 0, N'Антисептики', 0, 0, N'Витрина')
INSERT INTO [dbo].[drugs] ([barcode], [name], [measurement_unit], [quantity_per_pack], [manufacturer], [need_recipe], [pharmacologic_group], [is_narcotic], [is_vital], [storage_location]) VALUES (N'4601234567045', N'Йод', N'флакон', 1, N'Фармстандарт', 0, N'Антисептики', 0, 0, N'Шкаф')
INSERT INTO [dbo].[drugs] ([barcode], [name], [measurement_unit], [quantity_per_pack], [manufacturer], [need_recipe], [pharmacologic_group], [is_narcotic], [is_vital], [storage_location]) VALUES (N'4601234567046', N'Перекись водорода', N'флакон', 1, N'Самарамедпром', 0, N'Антисептики', 0, 0, N'Шкаф')
INSERT INTO [dbo].[drugs] ([barcode], [name], [measurement_unit], [quantity_per_pack], [manufacturer], [need_recipe], [pharmacologic_group], [is_narcotic], [is_vital], [storage_location]) VALUES (N'4601234567047', N'Зелёнка', N'флакон', 1, N'Фармстандарт', 0, N'Антисептики', 0, 0, N'Шкаф')
INSERT INTO [dbo].[drugs] ([barcode], [name], [measurement_unit], [quantity_per_pack], [manufacturer], [need_recipe], [pharmacologic_group], [is_narcotic], [is_vital], [storage_location]) VALUES (N'4601234567048', N'Ацикловир', N'таблетки', 20, N'Биосинтез', 0, N'Противовирусные', 0, 0, N'Шкаф')
INSERT INTO [dbo].[drugs] ([barcode], [name], [measurement_unit], [quantity_per_pack], [manufacturer], [need_recipe], [pharmacologic_group], [is_narcotic], [is_vital], [storage_location]) VALUES (N'4601234567049', N'Кагоцел', N'таблетки', 10, N'Ниармедик', 0, N'Противовирусные', 0, 0, N'Шкаф')
INSERT INTO [dbo].[drugs] ([barcode], [name], [measurement_unit], [quantity_per_pack], [manufacturer], [need_recipe], [pharmacologic_group], [is_narcotic], [is_vital], [storage_location]) VALUES (N'4601234567050', N'Ингавирин', N'капсулы', 7, N'Валента', 0, N'Противовирусные', 0, 0, N'Шкаф')
GO

INSERT INTO [dbo].[drug_items] ([uid], [barcode], [purchase_price], [retail_price], [expiration_date], [receipt_date], [item_status], [written_off_reason], [supplier_batch]) VALUES (N'A001', N'4601234567001', CAST(45.00 AS Decimal(10, 2)), CAST(62.00 AS Decimal(10, 2)), N'2027-06-15', N'2025-01-10', N'in_stock', NULL, N'BATCH-AN-001')
INSERT INTO [dbo].[drug_items] ([uid], [barcode], [purchase_price], [retail_price], [expiration_date], [receipt_date], [item_status], [written_off_reason], [supplier_batch]) VALUES (N'A002', N'4601234567001', CAST(45.00 AS Decimal(10, 2)), CAST(62.00 AS Decimal(10, 2)), N'2027-06-15', N'2025-01-10', N'in_stock', NULL, N'BATCH-AN-001')
INSERT INTO [dbo].[drug_items] ([uid], [barcode], [purchase_price], [retail_price], [expiration_date], [receipt_date], [item_status], [written_off_reason], [supplier_batch]) VALUES (N'A003', N'4601234567001', CAST(45.00 AS Decimal(10, 2)), CAST(62.00 AS Decimal(10, 2)), N'2027-06-15', N'2025-03-20', N'in_stock', NULL, N'BATCH-AN-002')
INSERT INTO [dbo].[drug_items] ([uid], [barcode], [purchase_price], [retail_price], [expiration_date], [receipt_date], [item_status], [written_off_reason], [supplier_batch]) VALUES (N'AA01', N'4601234567027', CAST(280.00 AS Decimal(10, 2)), CAST(380.00 AS Decimal(10, 2)), N'2027-08-25', N'2025-02-05', N'sold', NULL, N'BATCH-VD-001')
INSERT INTO [dbo].[drug_items] ([uid], [barcode], [purchase_price], [retail_price], [expiration_date], [receipt_date], [item_status], [written_off_reason], [supplier_batch]) VALUES (N'AA02', N'4601234567027', CAST(280.00 AS Decimal(10, 2)), CAST(380.00 AS Decimal(10, 2)), N'2027-08-25', N'2025-02-05', N'sold', NULL, N'BATCH-VD-001')
INSERT INTO [dbo].[drug_items] ([uid], [barcode], [purchase_price], [retail_price], [expiration_date], [receipt_date], [item_status], [written_off_reason], [supplier_batch]) VALUES (N'B001', N'4601234567002', CAST(78.00 AS Decimal(10, 2)), CAST(110.00 AS Decimal(10, 2)), N'2028-02-28', N'2025-02-15', N'in_stock', NULL, N'BATCH-IB-001')
INSERT INTO [dbo].[drug_items] ([uid], [barcode], [purchase_price], [retail_price], [expiration_date], [receipt_date], [item_status], [written_off_reason], [supplier_batch]) VALUES (N'B002', N'4601234567002', CAST(78.00 AS Decimal(10, 2)), CAST(110.00 AS Decimal(10, 2)), N'2027-11-10', N'2025-02-15', N'reserved', N'Иван Григориевич', N'BATCH-IB-001')
INSERT INTO [dbo].[drug_items] ([uid], [barcode], [purchase_price], [retail_price], [expiration_date], [receipt_date], [item_status], [written_off_reason], [supplier_batch]) VALUES (N'BB01', N'4601234567028', CAST(230.00 AS Decimal(10, 2)), CAST(310.00 AS Decimal(10, 2)), N'2028-04-15', N'2025-05-25', N'in_stock', NULL, N'BATCH-KM-001')
INSERT INTO [dbo].[drug_items] ([uid], [barcode], [purchase_price], [retail_price], [expiration_date], [receipt_date], [item_status], [written_off_reason], [supplier_batch]) VALUES (N'C001', N'4601234567003', CAST(25.00 AS Decimal(10, 2)), CAST(38.00 AS Decimal(10, 2)), N'2028-05-20', N'2025-04-01', N'in_stock', NULL, N'BATCH-PR-001')
INSERT INTO [dbo].[drug_items] ([uid], [barcode], [purchase_price], [retail_price], [expiration_date], [receipt_date], [item_status], [written_off_reason], [supplier_batch]) VALUES (N'C002', N'4601234567003', CAST(25.00 AS Decimal(10, 2)), CAST(38.00 AS Decimal(10, 2)), N'2028-05-20', N'2025-04-01', N'written_off', N'Повреждён блистер', N'BATCH-PR-001')
INSERT INTO [dbo].[drug_items] ([uid], [barcode], [purchase_price], [retail_price], [expiration_date], [receipt_date], [item_status], [written_off_reason], [supplier_batch]) VALUES (N'CC01', N'4601234567029', CAST(350.00 AS Decimal(10, 2)), CAST(470.00 AS Decimal(10, 2)), N'2027-10-30', N'2025-03-30', N'in_stock', NULL, N'BATCH-MG-001')
INSERT INTO [dbo].[drug_items] ([uid], [barcode], [purchase_price], [retail_price], [expiration_date], [receipt_date], [item_status], [written_off_reason], [supplier_batch]) VALUES (N'D001', N'4601234567004', CAST(180.00 AS Decimal(10, 2)), CAST(245.00 AS Decimal(10, 2)), N'2026-09-30', N'2025-01-20', N'in_stock', NULL, N'BATCH-KT-001')
INSERT INTO [dbo].[drug_items] ([uid], [barcode], [purchase_price], [retail_price], [expiration_date], [receipt_date], [item_status], [written_off_reason], [supplier_batch]) VALUES (N'DD01', N'4601234567030', CAST(120.00 AS Decimal(10, 2)), CAST(170.00 AS Decimal(10, 2)), N'2028-02-28', N'2025-04-10', N'in_stock', NULL, N'BATCH-RJ-001')
INSERT INTO [dbo].[drug_items] ([uid], [barcode], [purchase_price], [retail_price], [expiration_date], [receipt_date], [item_status], [written_off_reason], [supplier_batch]) VALUES (N'DD02', N'4601234567030', CAST(120.00 AS Decimal(10, 2)), CAST(170.00 AS Decimal(10, 2)), N'2028-02-28', N'2025-04-10', N'quarantined', NULL, N'BATCH-RJ-001')
INSERT INTO [dbo].[drug_items] ([uid], [barcode], [purchase_price], [retail_price], [expiration_date], [receipt_date], [item_status], [written_off_reason], [supplier_batch]) VALUES (N'E001', N'4601234567005', CAST(55.00 AS Decimal(10, 2)), CAST(78.00 AS Decimal(10, 2)), N'2027-12-31', N'2025-05-10', N'in_stock', NULL, N'BATCH-DC-001')
INSERT INTO [dbo].[drug_items] ([uid], [barcode], [purchase_price], [retail_price], [expiration_date], [receipt_date], [item_status], [written_off_reason], [supplier_batch]) VALUES (N'E002', N'4601234567005', CAST(55.00 AS Decimal(10, 2)), CAST(78.00 AS Decimal(10, 2)), N'2027-08-15', N'2025-05-10', N'in_stock', NULL, N'BATCH-DC-001')
INSERT INTO [dbo].[drug_items] ([uid], [barcode], [purchase_price], [retail_price], [expiration_date], [receipt_date], [item_status], [written_off_reason], [supplier_batch]) VALUES (N'EE01', N'4601234567031', CAST(45.00 AS Decimal(10, 2)), CAST(65.00 AS Decimal(10, 2)), N'2028-07-10', N'2025-06-01', N'reserved', N'Олег Олегович', N'BATCH-GL-001')
INSERT INTO [dbo].[drug_items] ([uid], [barcode], [purchase_price], [retail_price], [expiration_date], [receipt_date], [item_status], [written_off_reason], [supplier_batch]) VALUES (N'EE02', N'4601234567031', CAST(45.00 AS Decimal(10, 2)), CAST(65.00 AS Decimal(10, 2)), N'2023-07-10', N'2025-06-01', N'written_off', N'Истёк срок годности', N'BATCH-GL-001')
INSERT INTO [dbo].[drug_items] ([uid], [barcode], [purchase_price], [retail_price], [expiration_date], [receipt_date], [item_status], [written_off_reason], [supplier_batch]) VALUES (N'F001', N'4601234567006', CAST(120.00 AS Decimal(10, 2)), CAST(165.00 AS Decimal(10, 2)), N'2026-04-15', N'2025-03-01', N'written_off', N'Истёк срок годности', N'BATCH-AMX-001')
INSERT INTO [dbo].[drug_items] ([uid], [barcode], [purchase_price], [retail_price], [expiration_date], [receipt_date], [item_status], [written_off_reason], [supplier_batch]) VALUES (N'F002', N'4601234567006', CAST(120.00 AS Decimal(10, 2)), CAST(165.00 AS Decimal(10, 2)), N'2026-04-15', N'2025-03-01', N'written_off', N'Истёк срок годности', N'BATCH-AMX-001')
INSERT INTO [dbo].[drug_items] ([uid], [barcode], [purchase_price], [retail_price], [expiration_date], [receipt_date], [item_status], [written_off_reason], [supplier_batch]) VALUES (N'FF01', N'4601234567032', CAST(75.00 AS Decimal(10, 2)), CAST(110.00 AS Decimal(10, 2)), N'2027-05-15', N'2025-01-30', N'sold', NULL, N'BATCH-FZ-SECURE')
INSERT INTO [dbo].[drug_items] ([uid], [barcode], [purchase_price], [retail_price], [expiration_date], [receipt_date], [item_status], [written_off_reason], [supplier_batch]) VALUES (N'G001', N'4601234567007', CAST(210.00 AS Decimal(10, 2)), CAST(290.00 AS Decimal(10, 2)), N'2027-01-20', N'2025-02-28', N'in_stock', NULL, N'BATCH-AZ-001')
INSERT INTO [dbo].[drug_items] ([uid], [barcode], [purchase_price], [retail_price], [expiration_date], [receipt_date], [item_status], [written_off_reason], [supplier_batch]) VALUES (N'GG01', N'4601234567033', CAST(320.00 AS Decimal(10, 2)), CAST(430.00 AS Decimal(10, 2)), N'2028-01-20', N'2025-05-10', N'in_stock', NULL, N'BATCH-AF-001')
INSERT INTO [dbo].[drug_items] ([uid], [barcode], [purchase_price], [retail_price], [expiration_date], [receipt_date], [item_status], [written_off_reason], [supplier_batch]) VALUES (N'H001', N'4601234567008', CAST(95.00 AS Decimal(10, 2)), CAST(140.00 AS Decimal(10, 2)), N'2026-07-10', N'2025-04-15', N'in_stock', NULL, N'BATCH-CF-001')
INSERT INTO [dbo].[drug_items] ([uid], [barcode], [purchase_price], [retail_price], [expiration_date], [receipt_date], [item_status], [written_off_reason], [supplier_batch]) VALUES (N'H002', N'4601234567008', CAST(95.00 AS Decimal(10, 2)), CAST(140.00 AS Decimal(10, 2)), N'2026-07-10', N'2025-04-15', N'sold', NULL, N'BATCH-CF-001')
INSERT INTO [dbo].[drug_items] ([uid], [barcode], [purchase_price], [retail_price], [expiration_date], [receipt_date], [item_status], [written_off_reason], [supplier_batch]) VALUES (N'HH01', N'4601234567034', CAST(280.00 AS Decimal(10, 2)), CAST(390.00 AS Decimal(10, 2)), N'2026-11-30', N'2025-02-25', N'in_stock', NULL, N'BATCH-NP-001')
INSERT INTO [dbo].[drug_items] ([uid], [barcode], [purchase_price], [retail_price], [expiration_date], [receipt_date], [item_status], [written_off_reason], [supplier_batch]) VALUES (N'I001', N'4601234567009', CAST(130.00 AS Decimal(10, 2)), CAST(185.00 AS Decimal(10, 2)), N'2027-03-05', N'2025-06-01', N'in_stock', NULL, N'BATCH-CP-001')
INSERT INTO [dbo].[drug_items] ([uid], [barcode], [purchase_price], [retail_price], [expiration_date], [receipt_date], [item_status], [written_off_reason], [supplier_batch]) VALUES (N'II01', N'4601234567035', CAST(260.00 AS Decimal(10, 2)), CAST(360.00 AS Decimal(10, 2)), N'2027-04-05', N'2025-03-05', N'in_stock', NULL, N'BATCH-FB-001')
INSERT INTO [dbo].[drug_items] ([uid], [barcode], [purchase_price], [retail_price], [expiration_date], [receipt_date], [item_status], [written_off_reason], [supplier_batch]) VALUES (N'J001', N'4601234567010', CAST(85.00 AS Decimal(10, 2)), CAST(120.00 AS Decimal(10, 2)), N'2026-11-25', N'2025-05-20', N'in_stock', NULL, N'BATCH-DX-001')
INSERT INTO [dbo].[drug_items] ([uid], [barcode], [purchase_price], [retail_price], [expiration_date], [receipt_date], [item_status], [written_off_reason], [supplier_batch]) VALUES (N'JJ01', N'4601234567036', CAST(50.00 AS Decimal(10, 2)), CAST(72.00 AS Decimal(10, 2)), N'2027-12-20', N'2025-06-05', N'in_stock', NULL, N'BATCH-BR-001')
INSERT INTO [dbo].[drug_items] ([uid], [barcode], [purchase_price], [retail_price], [expiration_date], [receipt_date], [item_status], [written_off_reason], [supplier_batch]) VALUES (N'K001', N'4601234567011', CAST(60.00 AS Decimal(10, 2)), CAST(85.00 AS Decimal(10, 2)), N'2027-09-10', N'2025-01-05', N'in_stock', NULL, N'BATCH-CAP-001')
INSERT INTO [dbo].[drug_items] ([uid], [barcode], [purchase_price], [retail_price], [expiration_date], [receipt_date], [item_status], [written_off_reason], [supplier_batch]) VALUES (N'K002', N'4601234567011', CAST(60.00 AS Decimal(10, 2)), CAST(85.00 AS Decimal(10, 2)), N'2025-04-01', N'2024-10-15', N'written_off', N'Истёк срок годности', N'BATCH-CAP-OLD')
INSERT INTO [dbo].[drug_items] ([uid], [barcode], [purchase_price], [retail_price], [expiration_date], [receipt_date], [item_status], [written_off_reason], [supplier_batch]) VALUES (N'KK01', N'4601234567037', CAST(160.00 AS Decimal(10, 2)), CAST(225.00 AS Decimal(10, 2)), N'2026-09-15', N'2025-04-05', N'in_stock', NULL, N'BATCH-AMB-001')
INSERT INTO [dbo].[drug_items] ([uid], [barcode], [purchase_price], [retail_price], [expiration_date], [receipt_date], [item_status], [written_off_reason], [supplier_batch]) VALUES (N'L001', N'4601234567012', CAST(75.00 AS Decimal(10, 2)), CAST(105.00 AS Decimal(10, 2)), N'2028-01-15', N'2025-03-10', N'in_stock', NULL, N'BATCH-EN-001')
INSERT INTO [dbo].[drug_items] ([uid], [barcode], [purchase_price], [retail_price], [expiration_date], [receipt_date], [item_status], [written_off_reason], [supplier_batch]) VALUES (N'LL01', N'4601234567038', CAST(230.00 AS Decimal(10, 2)), CAST(315.00 AS Decimal(10, 2)), N'2027-06-25', N'2025-02-20', N'in_stock', NULL, N'BATCH-ACC-001')
INSERT INTO [dbo].[drug_items] ([uid], [barcode], [purchase_price], [retail_price], [expiration_date], [receipt_date], [item_status], [written_off_reason], [supplier_batch]) VALUES (N'LL02', N'4601234567038', CAST(230.00 AS Decimal(10, 2)), CAST(315.00 AS Decimal(10, 2)), N'2027-06-25', N'2025-02-20', N'in_stock', NULL, N'BATCH-ACC-001')
INSERT INTO [dbo].[drug_items] ([uid], [barcode], [purchase_price], [retail_price], [expiration_date], [receipt_date], [item_status], [written_off_reason], [supplier_batch]) VALUES (N'M001', N'4601234567013', CAST(140.00 AS Decimal(10, 2)), CAST(195.00 AS Decimal(10, 2)), N'2027-06-30', N'2025-02-20', N'in_stock', NULL, N'BATCH-BS-001')
INSERT INTO [dbo].[drug_items] ([uid], [barcode], [purchase_price], [retail_price], [expiration_date], [receipt_date], [item_status], [written_off_reason], [supplier_batch]) VALUES (N'M002', N'4601234567013', CAST(140.00 AS Decimal(10, 2)), CAST(195.00 AS Decimal(10, 2)), N'2027-06-30', N'2025-02-20', N'in_stock', NULL, N'BATCH-BS-001')
INSERT INTO [dbo].[drug_items] ([uid], [barcode], [purchase_price], [retail_price], [expiration_date], [receipt_date], [item_status], [written_off_reason], [supplier_batch]) VALUES (N'MM01', N'4601234567039', CAST(140.00 AS Decimal(10, 2)), CAST(195.00 AS Decimal(10, 2)), N'2027-03-10', N'2025-05-30', N'in_stock', NULL, N'BATCH-ING-001')
INSERT INTO [dbo].[drug_items] ([uid], [barcode], [purchase_price], [retail_price], [expiration_date], [receipt_date], [item_status], [written_off_reason], [supplier_batch]) VALUES (N'N001', N'4601234567014', CAST(160.00 AS Decimal(10, 2)), CAST(220.00 AS Decimal(10, 2)), N'2027-10-20', N'2025-04-25', N'in_stock', NULL, N'BATCH-AM-001')
INSERT INTO [dbo].[drug_items] ([uid], [barcode], [purchase_price], [retail_price], [expiration_date], [receipt_date], [item_status], [written_off_reason], [supplier_batch]) VALUES (N'NN01', N'4601234567040', CAST(20.00 AS Decimal(10, 2)), CAST(32.00 AS Decimal(10, 2)), N'2028-05-15', N'2025-06-10', N'in_stock', NULL, N'BATCH-MK-001')
INSERT INTO [dbo].[drug_items] ([uid], [barcode], [purchase_price], [retail_price], [expiration_date], [receipt_date], [item_status], [written_off_reason], [supplier_batch]) VALUES (N'NN02', N'4601234567040', CAST(20.00 AS Decimal(10, 2)), CAST(32.00 AS Decimal(10, 2)), N'2028-05-15', N'2025-06-10', N'written_off', N'Разбита упаковка при приёмке', N'BATCH-MK-001')
INSERT INTO [dbo].[drug_items] ([uid], [barcode], [purchase_price], [retail_price], [expiration_date], [receipt_date], [item_status], [written_off_reason], [supplier_batch]) VALUES (N'O001', N'4601234567015', CAST(30.00 AS Decimal(10, 2)), CAST(45.00 AS Decimal(10, 2)), N'2028-08-15', N'2025-06-10', N'sold', NULL, N'BATCH-VL-001')
INSERT INTO [dbo].[drug_items] ([uid], [barcode], [purchase_price], [retail_price], [expiration_date], [receipt_date], [item_status], [written_off_reason], [supplier_batch]) VALUES (N'O002', N'4601234567015', CAST(30.00 AS Decimal(10, 2)), CAST(45.00 AS Decimal(10, 2)), N'2028-08-15', N'2025-06-10', N'sold', NULL, N'BATCH-VL-001')
INSERT INTO [dbo].[drug_items] ([uid], [barcode], [purchase_price], [retail_price], [expiration_date], [receipt_date], [item_status], [written_off_reason], [supplier_batch]) VALUES (N'O003', N'4601234567015', CAST(30.00 AS Decimal(10, 2)), CAST(45.00 AS Decimal(10, 2)), N'2028-08-15', N'2025-06-10', N'written_off', N'Смята коробка при доставке', N'BATCH-VL-001')
INSERT INTO [dbo].[drug_items] ([uid], [barcode], [purchase_price], [retail_price], [expiration_date], [receipt_date], [item_status], [written_off_reason], [supplier_batch]) VALUES (N'OO01', N'4601234567041', CAST(190.00 AS Decimal(10, 2)), CAST(260.00 AS Decimal(10, 2)), N'2026-08-20', N'2025-01-10', N'in_stock', NULL, N'BATCH-PRD-001')
INSERT INTO [dbo].[drug_items] ([uid], [barcode], [purchase_price], [retail_price], [expiration_date], [receipt_date], [item_status], [written_off_reason], [supplier_batch]) VALUES (N'P001', N'4601234567016', CAST(110.00 AS Decimal(10, 2)), CAST(155.00 AS Decimal(10, 2)), N'2027-05-30', N'2025-01-15', N'in_stock', NULL, N'BATCH-OM-001')
INSERT INTO [dbo].[drug_items] ([uid], [barcode], [purchase_price], [retail_price], [expiration_date], [receipt_date], [item_status], [written_off_reason], [supplier_batch]) VALUES (N'P002', N'4601234567016', CAST(110.00 AS Decimal(10, 2)), CAST(155.00 AS Decimal(10, 2)), N'2027-05-30', N'2025-01-15', N'reserved', NULL, N'BATCH-OM-001')
INSERT INTO [dbo].[drug_items] ([uid], [barcode], [purchase_price], [retail_price], [expiration_date], [receipt_date], [item_status], [written_off_reason], [supplier_batch]) VALUES (N'PP01', N'4601234567042', CAST(210.00 AS Decimal(10, 2)), CAST(290.00 AS Decimal(10, 2)), N'2026-10-15', N'2025-02-15', N'in_stock', NULL, N'BATCH-DX-001')
INSERT INTO [dbo].[drug_items] ([uid], [barcode], [purchase_price], [retail_price], [expiration_date], [receipt_date], [item_status], [written_off_reason], [supplier_batch]) VALUES (N'Q001', N'4601234567017', CAST(90.00 AS Decimal(10, 2)), CAST(130.00 AS Decimal(10, 2)), N'2028-03-10', N'2025-05-05', N'in_stock', NULL, N'BATCH-PN-001')
INSERT INTO [dbo].[drug_items] ([uid], [barcode], [purchase_price], [retail_price], [expiration_date], [receipt_date], [item_status], [written_off_reason], [supplier_batch]) VALUES (N'Q002', N'4601234567017', CAST(90.00 AS Decimal(10, 2)), CAST(130.00 AS Decimal(10, 2)), N'2028-03-10', N'2025-05-05', N'in_stock', NULL, N'BATCH-PN-001')
INSERT INTO [dbo].[drug_items] ([uid], [barcode], [purchase_price], [retail_price], [expiration_date], [receipt_date], [item_status], [written_off_reason], [supplier_batch]) VALUES (N'QQ01', N'4601234567043', CAST(170.00 AS Decimal(10, 2)), CAST(235.00 AS Decimal(10, 2)), N'2028-03-25', N'2025-05-20', N'in_stock', NULL, N'BATCH-LT-001')
INSERT INTO [dbo].[drug_items] ([uid], [barcode], [purchase_price], [retail_price], [expiration_date], [receipt_date], [item_status], [written_off_reason], [supplier_batch]) VALUES (N'R001', N'4601234567018', CAST(200.00 AS Decimal(10, 2)), CAST(275.00 AS Decimal(10, 2)), N'2027-02-15', N'2025-03-25', N'in_stock', NULL, N'BATCH-SM-001')
INSERT INTO [dbo].[drug_items] ([uid], [barcode], [purchase_price], [retail_price], [expiration_date], [receipt_date], [item_status], [written_off_reason], [supplier_batch]) VALUES (N'RR01', N'4601234567044', CAST(65.00 AS Decimal(10, 2)), CAST(92.00 AS Decimal(10, 2)), N'2027-11-10', N'2025-04-15', N'in_stock', NULL, N'BATCH-LV-001')
INSERT INTO [dbo].[drug_items] ([uid], [barcode], [purchase_price], [retail_price], [expiration_date], [receipt_date], [item_status], [written_off_reason], [supplier_batch]) VALUES (N'RR02', N'4601234567044', CAST(65.00 AS Decimal(10, 2)), CAST(92.00 AS Decimal(10, 2)), N'2027-11-10', N'2025-04-15', N'sold', NULL, N'BATCH-LV-001')
INSERT INTO [dbo].[drug_items] ([uid], [barcode], [purchase_price], [retail_price], [expiration_date], [receipt_date], [item_status], [written_off_reason], [supplier_batch]) VALUES (N'S001', N'4601234567019', CAST(250.00 AS Decimal(10, 2)), CAST(340.00 AS Decimal(10, 2)), N'2027-11-05', N'2025-04-30', N'in_stock', NULL, N'BATCH-ES-001')
INSERT INTO [dbo].[drug_items] ([uid], [barcode], [purchase_price], [retail_price], [expiration_date], [receipt_date], [item_status], [written_off_reason], [supplier_batch]) VALUES (N'SS01', N'4601234567045', CAST(18.00 AS Decimal(10, 2)), CAST(28.00 AS Decimal(10, 2)), N'2029-01-15', N'2025-06-15', N'in_stock', NULL, N'BATCH-IOD-001')
INSERT INTO [dbo].[drug_items] ([uid], [barcode], [purchase_price], [retail_price], [expiration_date], [receipt_date], [item_status], [written_off_reason], [supplier_batch]) VALUES (N'T001', N'4601234567020', CAST(35.00 AS Decimal(10, 2)), CAST(52.00 AS Decimal(10, 2)), N'2028-06-20', N'2025-06-15', N'in_stock', NULL, N'BATCH-LP-001')
INSERT INTO [dbo].[drug_items] ([uid], [barcode], [purchase_price], [retail_price], [expiration_date], [receipt_date], [item_status], [written_off_reason], [supplier_batch]) VALUES (N'TT01', N'4601234567046', CAST(12.00 AS Decimal(10, 2)), CAST(20.00 AS Decimal(10, 2)), N'2028-12-31', N'2025-06-15', N'in_stock', NULL, N'BATCH-PER-001')
INSERT INTO [dbo].[drug_items] ([uid], [barcode], [purchase_price], [retail_price], [expiration_date], [receipt_date], [item_status], [written_off_reason], [supplier_batch]) VALUES (N'U001', N'4601234567021', CAST(130.00 AS Decimal(10, 2)), CAST(180.00 AS Decimal(10, 2)), N'2027-09-25', N'2025-02-10', N'in_stock', NULL, N'BATCH-SP-001')
INSERT INTO [dbo].[drug_items] ([uid], [barcode], [purchase_price], [retail_price], [expiration_date], [receipt_date], [item_status], [written_off_reason], [supplier_batch]) VALUES (N'U002', N'4601234567021', CAST(130.00 AS Decimal(10, 2)), CAST(180.00 AS Decimal(10, 2)), N'2027-04-10', N'2025-02-10', N'written_off', N'Истёк срок годности', N'BATCH-SP-OLD')
INSERT INTO [dbo].[drug_items] ([uid], [barcode], [purchase_price], [retail_price], [expiration_date], [receipt_date], [item_status], [written_off_reason], [supplier_batch]) VALUES (N'UU01', N'4601234567047', CAST(15.00 AS Decimal(10, 2)), CAST(25.00 AS Decimal(10, 2)), N'2028-10-20', N'2025-06-15', N'in_stock', NULL, N'BATCH-ZL-001')
INSERT INTO [dbo].[drug_items] ([uid], [barcode], [purchase_price], [retail_price], [expiration_date], [receipt_date], [item_status], [written_off_reason], [supplier_batch]) VALUES (N'V001', N'4601234567022', CAST(150.00 AS Decimal(10, 2)), CAST(210.00 AS Decimal(10, 2)), N'2028-01-30', N'2025-05-15', N'quarantined', N'Карантин по жалобе №0', N'BATCH-CT-001')
INSERT INTO [dbo].[drug_items] ([uid], [barcode], [purchase_price], [retail_price], [expiration_date], [receipt_date], [item_status], [written_off_reason], [supplier_batch]) VALUES (N'VV01', N'4601234567048', CAST(95.00 AS Decimal(10, 2)), CAST(135.00 AS Decimal(10, 2)), N'2027-07-30', N'2025-03-10', N'in_stock', NULL, N'BATCH-ACV-001')
INSERT INTO [dbo].[drug_items] ([uid], [barcode], [purchase_price], [retail_price], [expiration_date], [receipt_date], [item_status], [written_off_reason], [supplier_batch]) VALUES (N'W001', N'4601234567023', CAST(310.00 AS Decimal(10, 2)), CAST(420.00 AS Decimal(10, 2)), N'2026-02-15', N'2025-03-15', N'written_off', N'Истёк срок годности', N'BATCH-CL-001')
INSERT INTO [dbo].[drug_items] ([uid], [barcode], [purchase_price], [retail_price], [expiration_date], [receipt_date], [item_status], [written_off_reason], [supplier_batch]) VALUES (N'WW01', N'4601234567049', CAST(240.00 AS Decimal(10, 2)), CAST(330.00 AS Decimal(10, 2)), N'2027-02-28', N'2025-04-20', N'in_stock', N'', N'BATCH-KG-001')
INSERT INTO [dbo].[drug_items] ([uid], [barcode], [purchase_price], [retail_price], [expiration_date], [receipt_date], [item_status], [written_off_reason], [supplier_batch]) VALUES (N'X001', N'4601234567024', CAST(180.00 AS Decimal(10, 2)), CAST(250.00 AS Decimal(10, 2)), N'2027-07-20', N'2025-04-20', N'in_stock', NULL, N'BATCH-ZD-001')
INSERT INTO [dbo].[drug_items] ([uid], [barcode], [purchase_price], [retail_price], [expiration_date], [receipt_date], [item_status], [written_off_reason], [supplier_batch]) VALUES (N'XX01', N'4601234567050', CAST(350.00 AS Decimal(10, 2)), CAST(480.00 AS Decimal(10, 2)), N'2027-09-05', N'2025-05-15', N'in_stock', NULL, N'BATCH-IGV-001')
INSERT INTO [dbo].[drug_items] ([uid], [barcode], [purchase_price], [retail_price], [expiration_date], [receipt_date], [item_status], [written_off_reason], [supplier_batch]) VALUES (N'Y001', N'4601234567025', CAST(220.00 AS Decimal(10, 2)), CAST(300.00 AS Decimal(10, 2)), N'2026-10-05', N'2025-01-25', N'in_stock', NULL, N'BATCH-TV-001')
INSERT INTO [dbo].[drug_items] ([uid], [barcode], [purchase_price], [retail_price], [expiration_date], [receipt_date], [item_status], [written_off_reason], [supplier_batch]) VALUES (N'Z001', N'4601234567026', CAST(40.00 AS Decimal(10, 2)), CAST(58.00 AS Decimal(10, 2)), N'2028-09-10', N'2025-06-20', N'in_stock', NULL, N'BATCH-ASK-001')
INSERT INTO [dbo].[drug_items] ([uid], [barcode], [purchase_price], [retail_price], [expiration_date], [receipt_date], [item_status], [written_off_reason], [supplier_batch]) VALUES (N'Z002', N'4601234567026', CAST(40.00 AS Decimal(10, 2)), CAST(58.00 AS Decimal(10, 2)), N'2028-09-10', N'2025-06-20', N'in_stock', NULL, N'BATCH-ASK-001')
GO

SET IDENTITY_INSERT [dbo].[sales_history] ON
INSERT INTO [dbo].[sales_history] ([sale_id], [uid], [sale_date], [sold_price]) VALUES (1, N'O001', N'2026-06-24 16:03:25', CAST(45.00 AS Decimal(10, 2)))
INSERT INTO [dbo].[sales_history] ([sale_id], [uid], [sale_date], [sold_price]) VALUES (2, N'AA01', N'2026-06-24 15:51:38', CAST(380.00 AS Decimal(10, 2)))
INSERT INTO [dbo].[sales_history] ([sale_id], [uid], [sale_date], [sold_price]) VALUES (3, N'AA02', N'2026-06-24 15:36:38', CAST(380.00 AS Decimal(10, 2)))
INSERT INTO [dbo].[sales_history] ([sale_id], [uid], [sale_date], [sold_price]) VALUES (4, N'FF01', N'2026-06-24 15:21:38', CAST(110.00 AS Decimal(10, 2)))
INSERT INTO [dbo].[sales_history] ([sale_id], [uid], [sale_date], [sold_price]) VALUES (5, N'H002', N'2026-06-24 15:06:38', CAST(140.00 AS Decimal(10, 2)))
INSERT INTO [dbo].[sales_history] ([sale_id], [uid], [sale_date], [sold_price]) VALUES (6, N'O002', N'2026-06-24 14:51:38', CAST(45.00 AS Decimal(10, 2)))
INSERT INTO [dbo].[sales_history] ([sale_id], [uid], [sale_date], [sold_price]) VALUES (7, N'RR02', N'2026-06-24 14:36:38', CAST(92.00 AS Decimal(10, 2)))
SET IDENTITY_INSERT [dbo].[sales_history] OFF
GO

SET IDENTITY_INSERT [dbo].[complaints] ON
INSERT INTO [dbo].[complaints] ([Id], [Uid], [DrugName], [DoctorName], [RecipeDetails], [PatientName], [PatientContact], [Comment], [ComplaintDate], [Status]) VALUES (1, N'A001', N'Анальгин 500мг', N'Иванов И.И.', N'Рецепт серии 77 №123456', N'Петров А.С.', N'+7(999)123-45-67', N'Посторонние вкрапления в таблетке, изменение цвета', N'2026-06-10 14:30:00', N'Новая')
INSERT INTO [dbo].[complaints] ([Id], [Uid], [DrugName], [DoctorName], [RecipeDetails], [PatientName], [PatientContact], [Comment], [ComplaintDate], [Status]) VALUES (2, N'B001', N'Ибупрофен 400мг', N'Смирнова Е.А.', N'Рецепт серии 50 №654321', N'Козлова М.В.', N'+7(916)555-88-99', N'Блистер вскрыт, не хватает 3 таблеток из 20', N'2026-06-15 09:15:00', N'Новая')
INSERT INTO [dbo].[complaints] ([Id], [Uid], [DrugName], [DoctorName], [RecipeDetails], [PatientName], [PatientContact], [Comment], [ComplaintDate], [Status]) VALUES (3, N'C001', N'Парацетамол 500мг', NULL, N'Без рецепта', N'Сидоров К.Н.', N'+7(903)222-33-44', N'Сильный химический запах от таблеток, отличается от обычного', N'2026-06-18 11:45:00', N'Новая')
INSERT INTO [dbo].[complaints] ([Id], [Uid], [DrugName], [DoctorName], [RecipeDetails], [PatientName], [PatientContact], [Comment], [ComplaintDate], [Status]) VALUES (4, N'D001', N'Кеторол 10мг', N'Кузнецов П.Д.', N'Рецепт серии 77 №998877', N'Михайлова А.В.', N'+7(925)444-55-66', N'Таблетки крошатся при извлечении из блистера, нарушена целостность', N'2026-06-22 16:00:00', N'Новая')
INSERT INTO [dbo].[complaints] ([Id], [Uid], [DrugName], [DoctorName], [RecipeDetails], [PatientName], [PatientContact], [Comment], [ComplaintDate], [Status]) VALUES (5, N'E001', N'Диклофенак 50мг', NULL, N'Без рецепта', N'Фёдоров Е.Л.', N'+7(926)777-88-00', N'Маркировка на блистере стёрта, невозможно прочитать срок годности', N'2026-06-24 08:10:00', N'Новая')
INSERT INTO [dbo].[complaints] ([Id], [Uid], [DrugName], [DoctorName], [RecipeDetails], [PatientName], [PatientContact], [Comment], [ComplaintDate], [Status]) VALUES (6, N'V001', N'Цетрин', N'Пупкин А.П', N'Рецепт', N'Иванов И. И', N'+8(800)555-35-35', N'', N'2026-06-25 23:50:30', N'Отправлена')
SET IDENTITY_INSERT [dbo].[complaints] OFF
GO

CREATE TRIGGER trg_AutoWriteOffExpiredDrugs
ON drug_items
AFTER INSERT, UPDATE
AS
BEGIN
    SET NOCOUNT ON;
    
    -- Обновляем статус для записей, у которых срок годности истек,
    -- но статус еще не "sold" и не "written_off"
    UPDATE drug_items
    SET 
        item_status = 'written_off',
        written_off_reason = 'Истёк срок годности'
    WHERE 
        expiration_date < GETDATE()
        AND item_status NOT IN ('sold', 'written_off');
END;
GO

CREATE TRIGGER trg_AutoLogSales
ON [dbo].[drug_items]
AFTER UPDATE
AS
BEGIN
    SET NOCOUNT ON;

    -- Вставляем запись в историю, только если статус изменился на 'sold'
    INSERT INTO [dbo].[sales_history] ([uid], [sale_date], [sold_price])
    SELECT 
        ins.[uid],
        GETDATE(), -- Текущее время продажи
        ins.[retail_price] -- Берем розничную цену из карточки товара
    FROM inserted ins
    INNER JOIN deleted del ON ins.[uid] = del.[uid]
    WHERE ins.[item_status] = 'sold' 
      AND (del.[item_status] IS NULL OR del.[item_status] <> 'sold');
END;
GO

CREATE PROCEDURE DeleteOldItems
AS
BEGIN
    SET NOCOUNT ON;

    -- Удаляем записи, которые подходят под наши условия
    DELETE FROM [dbo].[drug_items]
    WHERE 
        -- Условие 1: Прошло больше 6 месяцев с даты поступления
        [receipt_date] < DATEADD(month, -6, GETDATE())
        
        -- Условие 2: Статус является либо 'sold', либо 'written_off'
        AND [item_status] IN ('sold', 'written_off');
END;