﻿using System.Runtime.Serialization;

namespace FairMark.OmsApi.DataContracts
{
    /// <summary>
    /// 5.3.1.1. Справочник «Способ выпуска товаров в оборот» (releaseMethodType)
    /// </summary>
    public enum ReleaseMethodTypes
    {
        /// <summary>
        /// Производство в РФ
        /// </summary>
        [EnumMember(Value = @"PRODUCTION")]
        PRODUCTION = 0,

        /// <summary>
        /// Ввезен в РФ (Импорт)
        /// </summary>
        [EnumMember(Value = @"IMPORT")]
        IMPORT = 1,

        /// <summary>
        /// Маркировка остатков (доступно только для ТГ «Альтернативная табачная продукция», «Духи и туалетная вода», «Предметы одежды, белье постельное, столовое, туалетное и кухонное»)
        /// </summary>
        [EnumMember(Value = @"REMAINS")]
        REMAINS = 2,

        /// <summary>
        /// Доступен исключительно Операторам ЕАЭС для следующих товарных групп («Обувные товары», «Предметы одежды, белье постельное, столовое, туалетное и кухонное», «Шины и покрышки пневматические резиновые новые», «Духи и туалетная вода», «Фотокамеры (кроме кинокамер), фотовспышки и лампы-вспышки») в том числе «Молочная продукция»
        /// </summary>
        [EnumMember(Value = @"CROSSBORDER")]
        CROSSBORDER = 3,

        /// <summary>
        /// Перемаркировка (доступно только для ТГ «Предметы одежды, белье постельное, столовое, туалетное и кухонное», «Обувные товары», «Шины и покрышки пневматические резиновые новые», «Духи и туалетная вода», «Фотокамеры (кроме кинокамер), фотовспышки и лампывспышки», «Велосипеды и велосипедные рамы», «Кресла-коляски»).
        /// </summary>
        [EnumMember(Value = @"REMARK")]
        REMARK = 4,

        /// <summary>
        /// Принят на комиссию от физического лица (доступно для для ТГ «Предметы одежды, белье постельное, столовое, туалетное и кухонное», «Обувные товары»)
        /// </summary>
        [EnumMember(Value = @"COMMISSION")]
        COMMISSION = 5,
    }
}
