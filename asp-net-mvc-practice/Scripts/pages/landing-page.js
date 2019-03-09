$("#myform").kendoValidator({
    messages: {
        // defines a message for the custom validation rule
        custom: "올바른 이메일을 입력하세요.",

        // overrides the built-in message for the required rule
        required: "이메일을 입력하셔야 다음단계로 진행가능합니다.",

        // overrides the built-in message for the email rule
        // with a custom function that returns the actual message
        email: function (input) {
            return getMessage(input);
        }
    },
    rules: {
        custom: function (input) {
            if (input.is("[name=userEmail]")) {
                return true;
                //@todo : email 형태의 정규식으로 대체.
                //return input.val() === 'aloha@aloha.com';
            }
            return true;
        }
    }
});

function getMessage(input) {
    return input.data("message");
}