﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IndentifiedFace.Configurations.Language
{
    public class EnglishLanguagePackage : LanguagePackage
    {
        public string getMainFormTitle() { return "Nhận dạng khuôn mặt kết hợp chấm công"; }
        public string getErrorConnectToDatabaseMessage() { return "Không thể kết nối tới CSDL!"; }
        public string getErrorConnectToDatabaseTitle() { return "Lỗi!!";  }
        public string getAskRetryLoginMessage() { return "Đăng nhập lỗi. Vui lòng thử lại."; }
        public string getAskRetryLoginTitle() { return "Đăng nhập";  }
        public string getConfirmQuitApplicationMessage() { return "Bạn có thực sự muốn thoát?"; }
        public string getConfirmQuitApplicationTitle() { return "Thoát ứng dụng"; }
        public string getAuthorName() { return "Team1_Capstone1"; }
        public string getLoginFormTitle() { return "Đăng nhập"; }
        public string getLoginButtonLabel() { return "Đăng nhập"; }
        public string getQuitButtonTitle() { return "Thoát"; }
        public string getUsernameInputLabel() { return "Tên đăng nhập"; }
        public string getPasswordInputLabel() { return "Mật khẩu"; }
        public string getLoginFormFontName() { return "Times New Roman"; }
        public string getLoginFormCaption() { return "Đăng nhập~"; }

        public string getMainFormQuitConfimMessage() { return "Bạn có thực sự muốn thoát?"; }
        public string getMainFormQuitConfimTitle() { return "Tắt ứng dụng"; }
        public string getStatusClassLabel() { return "Department: "; }
        public string getStatusQuantityLabel() { return "Tổng NV: "; }
        public string getNoDataSelectedWhenDeleteErrorMessage() { return "Vui lòng chọn dữ liệu để xóa!"; }
        public string getNoDataSelectedWhenDeleteErrorTitle() { return "Xóa nhân viên"; }
        public string getMemberCodeAlias() { return "ID Employee:"; }
        public string getDeleteMembersButtonLabel() { return "Xóa"; }
        public string getAddMembersButtonLabel() { return "Thêm"; }
        public string getMakingRollCallButtonLabel() { return "Chấm công"; }
        public string getMainFormMenuFileLabel() { return "File"; }
        public string getMainFormMenuFileMemberListLabel() { return "Danh sách nhân viên"; }
        public string getMainFormMenuOperationLabel() { return "Thao tác"; }
        public string getMainFormMenuHelpLabel() { return "Trợ giúp"; }
        public string getMainFormMenuAboutLabel() { return "Thông tin"; }
        public string getLastNameAlias() { return "Firstname:  "; }
        public string getFirstNameAlias() { return "Lastname: "; }
        public string getMaleAlias() { return "Male"; }
        public string getFemaleAlias() { return "Female"; }
        public string getSexAlias() { return "Gender: "; }
        public string getBirthAlias() { return "Birthday: "; }
        public string getClassAlias() { return "Department: "; }

        public string getAboutFormFontName() { return "Microsoft Sans Serif"; }
        public string getAboutFormMainCaptionFontName() { return "Times New Roman"; }
        public string getAboutFormMainCaption() { return "Khoa DTQT"; }
        public string getAboutFormTopCaption() { return ""; }
        public string getAboutFormSubTopCaption() { return "DUY TAN UNIVERSITY"; }
        public string getAboutFormCenterCaption() { return ""; }
        public string getAboutFormSubTitle2() { return ""; }
        public string getAboutFormSubTitle1() { return ""; }
        public string getAboutFormTitle() { return "SPECIAL PROJECT"; }

        public string getMakingRollCallSuccessSerialMessage() { return "A"; }
        public string getMakingRollCallFailSerialMessage() { return "B"; }

        public string getMemeberInfoBlockTitle() { return "Thông tin nhân viên"; }
        public string getResetButtonTitle() { return "Reset"; }
        public string getAddMemberFormTitle() { return "Thêm nhân viên"; }
        public string getOperationsBlockTitle() { return "Thao tác"; }

        public string getFaceDetectingBlockTitle() { return "Nhận dạng khuôn mặt"; }
        public string getCameraActionButtonLabel() { return "Camera"; }
        public string getMembersNotMakingRollCallYetTitle() { return "Nhân viên đã được điểm danh!"; }
        public string getMembersAlreadyMakingRollCallTitle() { return "Nhân viên chưa được điểm danh!"; }
        public string getMakingRollCallOperationsBlockTitle() { return "Thao tác"; }
        public string getOutputDeviceSelectionTitle() { return "Thiết bị đầu ra: "; }
        public string getMakingRollCallFormTitle() { return "Chấm công"; }

        public string getMemberNotFoundMessage() { return "Nhân viên không tìm thấy!"; }
        public string getMemberNotFoundLabel() { return "Cảnh báo"; }

    }
}
