using System;
using Pelo.Common.Attributes;

namespace Pelo.Common.Enums
{
    public enum ErrorEnum
    {
        #region 400xxx

        [StringValue("Tên đăng nhập không được để trống")]
        USERNAME_IS_NOT_EMPTY = 400000,

        [StringValue("Mật khẩu không được để trống")]
        PASSWORD_IS_NOT_EMPTY = 400001,

        [StringValue("Ngày liên hệ không được để trống")]
        CONTACT_DATE_IS_NOT_NULL_OR_EMPTY = 400002,

        [StringValue("Ngày liên hệ không được nhỏ hơn ngày hiện tại")]
        CONTACT_DATE_CAN_NOT_LESS_THAN_CURRENT_DATE = 400003,

        [StringValue("Vui lòng thay đổi trạng thái hoặc bình luận")]
        CRM_COMMENT_IS_EMPTY = 400004,

        [StringValue("Bạn phải bình luận lý do khi chuyển sang trạng thái HỦY")]
        CRM_COMMENT_NEED_COMMENT_WHEN_DELETE = 400005,

        [StringValue("Nội dung tin nhắn không được để trống")]
        SMS_CONTENT_IS_NOT_NULL_OR_EMPTY = 400006,

        [StringValue("Tên khách hàng không được để trống")]
        CUSTOMER_NAME_IS_NOT_NULL_OR_EMPTY = 400007,

        [StringValue("Số điện thoại không được để trống")]
        CUSTOMER_PHONE_IS_NOT_NULL_OR_EMPTY = 400008,

        [StringValue("Bạn phải nhập nội dung bình luận hoặc đính kèm file")]
        COMMENT_IS_NOT_NULL_OR_EMPTY = 400009,

        [StringValue("Refresh token không được để trống")]
        REFRESH_TOKEN_IS_NULL_OR_EMPTY = 400010,

        [StringValue("Access token không được để trống")]
        ACCESS_TOKEN_IS_NULL_OR_EMPTY = 400011,

        [StringValue("Signing key không được để trống")]
        SIGNING_KEY_IS_NULL_OR_EMPTY = 400012,

        #endregion

        #region 500xxx

        [StringValue("Lỗi hệ thống, vui lòng thử lại sau giây lát")]
        BAD_REQUEST = 500999,

        [StringValue("Tên đăng nhập hoặc mật khẩu không chính xác")]
        AUTHENTICATION_WRONG = 500000,

        [StringValue("Token không chính xác")]
        TOKEN_INVALID = 500001,

        [StringValue("Người dùng không tồn tại")]
        USER_HAS_NOT_EXIST = 500002,

        [StringValue("Mật khẩu không chính xác")]
        OLD_PASSWORD_IS_INVALID = 500003,

        [StringValue("Người dùng này chưa cài đặt email. Vui lòng liên hệ quản trị viên")]
        EMAIL_IS_EMPTY = 500005,

        [StringValue("Tên đăng nhập hoặc email không chính xác")]
        USERNAME_OR_EMAIL_IS_INVALID = 500006,

        [StringValue("Không thể thay đổi thông tin cá nhân. Vui lòng thử lại sau")]
        CAN_NOT_CHANGE_USER_INFORMATION = 500007,

        [StringValue("Tên tham số đã tồn tại")]
        APP_CONFIG_HAS_EXIST = 500008,

        [StringValue("Tham số không tồn tại")]
        APP_CONFIG_HAS_NOT_EXIST = 500009,

        [StringValue("Quyền hệ thống đã tồn tại")]
        ROLE_HAS_EXIST = 500010,

        [StringValue("Quyền hệ thống không tồn tại")]
        ROLE_HAS_NOT_EXIST = 500011,

        [StringValue("Chi nhánh đã tồn tại")]
        BRANCH_HAS_EXIST = 500012,

        [StringValue("Chi nhánh không tồn tại")]
        BRANCH_HAS_NOT_EXIST = 500013,

        [StringValue("Tên đăng nhập đã tồn tại")]
        USERNAME_HAS_EXIST = 500014,

        [StringValue("Nhóm khách hàng đã tồn tại")]
        CUSTOMER_GROUP_HAS_EXIST = 500015,

        [StringValue("Nhóm khách hàng không tồn tại")]
        CUSTOMER_GROUP_HAS_NOT_EXIST = 500016,

        [StringValue("Khách hàng đã tồn tại")]
        CUSTOMER_HAS_EXIST = 500017,

        [StringValue("Khách hàng không tồn tại")]
        CUSTOMER_HAS_NOT_EXIST = 500018,

        [StringValue("Thương hiệu đã tồn tại")]
        MANUFACTURER_HAS_EXIST = 500019,

        [StringValue("Thương hiệu không tồn tại")]
        MANUFACTURER_HAS_NOT_EXIST = 500020,

        [StringValue("Nhóm sản phẩm đã tồn tại")]
        PRODUCT_GROUP_HAS_EXIST = 500021,

        [StringValue("Nhóm sản phẩm không tồn tại")]
        PRODUCT_GROUP_HAS_NOT_EXIST = 500022,

        [StringValue("Đơn vị tính đã tồn tại")]
        PRODUCT_UNIT_HAS_EXIST = 500023,

        [StringValue("Đơn vị tính không tồn tại")]
        PRODUCT_UNIT_HAS_NOT_EXIST = 500024,

        [StringValue("Tình trạng sản phẩm đã tồn tại")]
        PRODUCT_STATUS_HAS_EXIST = 500025,

        [StringValue("Tình trạng sản phẩm không tồn tại")]
        PRODUCT_STATUS_HAS_NOT_EXIST = 500026,

        [StringValue("Quốc gia đã tồn tại")]
        COUNTRY_HAS_EXIST = 500027,

        [StringValue("Quốc gia không tồn tại")]
        COUNTRY_HAS_NOT_EXIST = 500028,

        [StringValue("Sản phẩm đã tồn tại")]
        PRODUCT_HAS_EXIST = 500029,

        [StringValue("Sản phẩm không tồn tại")]
        PRODUCT_HAS_NOT_EXIST = 500030,

        [StringValue("Nguồn khách hàng đã tồn tại")]
        CUSTOMER_SOURCE_HAS_EXIST = 500031,

        [StringValue("Nguồn khách hàng không tồn tại")]
        CUSTOMER_SOURCE_HAS_NOT_EXIST = 500032,

        [StringValue("Trạng thái CRM đã tồn tại")]
        CRM_STATUS_HAS_EXIST = 500033,

        [StringValue("Trạng thái CRM không tồn tại")]
        CRM_STATUS_HAS_NOT_EXIST = 500034,

        [StringValue("Mức độ khẩn cấp CRM đã tồn tại")]
        CRM_PRIORITY_HAS_EXIST = 500035,

        [StringValue("Mức độ khẩn cấp CRM không tồn tại")]
        CRM_PRIORITY_HAS_NOT_EXIST = 500036,

        [StringValue("Ngày liên hệ không được lớn hơn ngày hiện tại {0} ngày")]
        CONTACT_DATE_CAN_NOT_GREATER_THAN_CURRENT_DATE = 500037,

        [StringValue("Người dùng không đủ quyền để xem Crm này")]
        USER_DO_HAVE_NOT_PERMISSON_VIEW_THIS_CRM = 500038,

        [StringValue("Crm không tồn tại")]
        CRM_HAS_NOT_EXIST = 500039,

        [StringValue("Kiểu chốt đã tồn tại")]
        CRM_TYPE_HAS_EXIST = 500040,

        [StringValue("Kiểu chốt không tồn tại")]
        CRM_TYPE_HAS_NOT_EXIST = 500041,

        [StringValue("Hình thức thanh toán đã tồn tại")]
        PAY_METHOD_HAS_EXIST = 500042,

        [StringValue("Hình thức thanh toán không tồn tại")]
        PAY_METHOD_HAS_NOT_EXIST = 500043,

        [StringValue("Trạng thái đơn hàng đã tồn tại")]
        INVOICE_STATUS_HAS_EXIST = 500044,

        [StringValue("Trạng thái đơn hàng không tồn tại")]
        INVOICE_STATUS_HAS_NOT_EXIST = 500045,

        [StringValue("Trạng thái công việc đã tồn tại")]
        TASK_STATUS_HAS_EXIST = 500046,

        [StringValue("Trạng thái công việc không tồn tại")]
        TASK_STATUS_HAS_NOT_EXIST = 500047,

        [StringValue("Mức độ gấp đã tồn tại")]
        TASK_PRIORITY_HAS_EXIST = 500048,

        [StringValue("Mức độ gấp không tồn tại")]
        TASK_PRIORITY_HAS_NOT_EXIST = 500049,

        [StringValue("Loại công việc đã tồn tại")]
        TASK_TYPE_HAS_EXIST = 500050,

        [StringValue("Loại công việc không tồn tại")]
        TASK_TYPE_HAS_NOT_EXIST = 500051,

        [StringValue("Thời gian lặp lại đã tồn tại")]
        TASK_LOOP_HAS_EXIST = 500052,

        [StringValue("Thời gian lặp lại không tồn tại")]
        TASK_LOOP_HAS_NOT_EXIST = 500053,

        [StringValue("Trạng thái biên nhân đã tồn tại")]
        RECEIPT_STATUS_HAS_EXIST = 500054,

        [StringValue("Trạng thái biên nhận không tồn tại")]
        RECEIPT_STATUS_HAS_NOT_EXIST = 500055,

        [StringValue("Dịch vụ đã tồn tại")]
        RECEIPT_DESCRIPTION_HAS_EXIST = 500056,

        [StringValue("Dịch vụ không tồn tại")]
        RECEIPT_DESCRIPTION_HAS_NOT_EXIST = 500057,

        [StringValue("Trạng thái bảo hành đã tồn tại")]
        WARRANTY_STATUS_HAS_EXIST = 500058,

        [StringValue("Trạng thái bảo hành không tồn tại")]
        WARRANTY_STATUS_HAS_NOT_EXIST = 500059,

        [StringValue("Mô tả bảo hành đã tồn tại")]
        WARRANTY_DESCRIPTION_HAS_EXIST = 500060,

        [StringValue("Mô tả bảo hành không tồn tại")]
        WARRANTY_DESCRIPTION_HAS_NOT_EXIST = 500061,

        [StringValue("Trạng thái tuyển dụng đã tồn tại")]
        RECRUITMENT_STATUS_HAS_EXIST = 500062,

        [StringValue("Trạng thái tuyển dụng không tồn tại")]
        RECRUITMENT_STATUS_HAS_NOT_EXIST = 500063,

        [StringValue("Trạng thái ứng viên đã tồn tại")]
        CANDIDATE_STATUS_HAS_EXIST = 500064,

        [StringValue("Trạng thái ứng viên không tồn tại")]
        CANDIDATE_STATUS_HAS_NOT_EXIST = 500065,

        [StringValue("Ứng viên đã tồn tại")]
        CANDIDATE_HAS_EXIST = 500064,

        [StringValue("Ứng viên không tồn tại")]
        CANDIDATE_HAS_NOT_EXIST = 500065,

        [StringValue("Tên mức độ thân thiết đã tồn tại")]
        CUSTOMER_VIP_HAS_EXIST = 500066,

        [StringValue("Mức độ thân thiết không tồn tại")]
        CUSTOMER_VIP_HAS_NOT_EXIST = 500067,

        [StringValue("Lợi nhuận mức độ thân thiết đã tồn tại")]
        CUSTOMER_VIP_PROFIT_HAS_EXIST = 500068,

        [StringValue("Phường xã không tồn tại")]
        WARD_HAS_NOT_EXIST = 500069,

        [StringValue("Quận huyện không tồn tại")]
        DISTRICT_HAS_NOT_EXIST = 500070,

        [StringValue("Tỉnh thành không tồn tại")]
        PROVINCE_HAS_NOT_EXIST = 500071,

        [StringValue("Số điện thoại khách hàng đã tồn tại")]
        CUSTOMER_PHONE_HAS_EXIST = 500072,

        [StringValue("Token kHông hợp lệ")]
        INVALID_TOKEN = 500073,

        [StringValue("Không thể tạo mã token")]
        CAN_NOT_CREATE_TOKEN = 500074,

        [StringValue("Người dùng không đủ quyền thực hiện hành động này")]
        USER_DO_HAVE_NOT_PERMISSON_WITH_ACTION = 500075,

        [StringValue("Không thể thực hiện câu lệnh này: {0}")]
        SQL_QUERY_CAN_NOT_EXECUTE = 500076,

        [StringValue("Số điện thoại đã tồn tại")]
        PHONE_NUMBER_HAS_EXIST = 500077,

        #endregion
    }
}