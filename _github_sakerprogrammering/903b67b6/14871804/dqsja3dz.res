        ��  ��                        �����e                 
    <script src="//ajax.googleapis.com/ajax/libs/jquery/1.9.1/jquery.min.js" type="text/javascript"></script>
    <script src="//ajax.googleapis.com/ajax/libs/jqueryui/1.10.1/jquery-ui.min.js" type="text/javascript"></script>
    <script type="text/javascript">
        $(document).ready(function () {

            //$('#DivDoctor').hide();

            $(function () {
                $('#txtFromDate').val('');
                $('#txtToDate').datepicker({
                    dateFormat: 'yy-mm-dd'
                });
            });
            /*
            $('input[name=chkDoctor]').change(function () {
                if ($(this).attr('checked')) {
                    $('#DivDoctor').fadeOut();
                    return;
                }
                $('#DivDoctor').fadeIn();
            });

            $('input[name=chkChild]').change(function () {
                if ($(this).attr('checked')) {
                    $('#DivChild').fadeOut();
                    return;
                }
                $('#DivChild').fadeIn();
            });
            */

            $('#radioDiv input').click(function () {
                var selected = $("#radioDiv input:radio:checked").val();
                $("#DivDoctor").hide();
                $("#DivChild").hide();
                //alert(selected);
                //$("#info").text('Selected Value: ' + $("#RadioDiv input:radio:checked").val());
                if ($("#radioDiv input:radio:checked").val() == "Sjukskriven av läkare") {
                    $("#DivDoctor").fadeIn();
                }
                else if ($("#radioDiv input:radio:checked").val() == "Vård av barn") {
                    $("#DivChild").fadeIn();
                }
            });

        });
    </script>
