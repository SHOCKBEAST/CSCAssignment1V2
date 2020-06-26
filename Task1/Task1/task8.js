// Handles image upload
function uploadImage() {
	var preview = document.querySelector('img');
  var file = document.querySelector('input[type=file]').files[0];
  var reader = new FileReader();

  reader.addEventListener("load", function () {
    preview.src = reader.result;
    var imageData = reader.result;
    imageData = imageData.replace(/^data:image\/(.*);base64,/, '');
    predict(imageData);
  }, false);

  if (file) {
    reader.readAsDataURL(file);
    preview.style.display = "inherit";
  }
}
function predict(photourl) {
    var nanoclient = new RestClient("https://app.nanonets.com/api/v2/OCR/Model/e252887c-03d4-44d1-b433-3554b69511fd/LabelUrls/");
    var request = new RestRequest(Method.POST);
    request.AddHeader("authorization", "Basic " + Convert.ToBase64String(Encoding.Default.GetBytes("XtgHDan8kaAK4wLuflk4YRib9S9guAq9")));

    request.AddHeader("accept", "application/x-www-form-urlencoded");
    request.AddParameter("urls", photourl);
    IRestResponse test = nanoclient.Execute(request);

    JObject json = JObject.Parse(nanoresponse.Content);
    var prediction = json["result"][0]["prediction"];

    foreach(var predict in prediction)
    {
        String label = (string)predict["label"];

        if (label.ToLower().Contains("total")) {
            total = (string)predict["ocr_text"];


        }
    }
}