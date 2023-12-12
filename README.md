#GPT UTILIZATION 
<h1>After pulling make a folder inside chatbot folder with any name that you want and download  the model it everything will be clear as i go with the documentations in this case i called it Model !! </h1>


How to make the GPT ... UNDER MY CONTROL!! 
First, let's answer the fundamental question: What is GPT?
GPT stands for Generative Pretrained Transformer. It is a large language model that enables users to engage in conversations. 
What can GPT be used for?
GPT has versatile applications such as coding, debugging, educational purposes, and customer support. People rely on it in their daily lives because it provides quick and accurate answers. 
Now, why should we avoid using CHATGPT?
CHATGPT may pose security risks as it requires access to other people's data. Moreover, the data it's trained on can be outdated and not up to date with the latest vulnerabilities. By having control over our own GPT model, we can ensure better security and peace of mind. 
So, why build our own GPT?
Running a model like ChatGPT on older computers can lead to long loading times due to the large file sizes. This can be particularly troublesome if you want the model to be accessible across different devices, including lower-end ones. By building and controlling your GPT on your own PC, you can optimize performance and utilize it offline. In this article, I'll guide you through the process of taking control of GPT on your computer. Let's get started! 
While most people use ChatGPT online, I will proudly show you how to have local control over it. Here's what you'll need to start building:
IDE: Visual STUDIO (2022) Download link: https://visualstudio.microsoft.com/downloads/
Download Extensions:
 To find extensions, navigate to Tools >> NuGet Package Manager >> NuGet Package Manager For Solutions
 




What extensions should you download? Install the following packages:
•	LLamaSharp
•	LLamaSharp.Backend.CPU
•	LLamaSharp.semantic-kernel

It should look like this: 🛠️
 

How to download the model engine:
To launch the ChatGPT model, you'll need to download the Lama script launcher. For optimal performance, I recommend using this version: https://huggingface.co/TheBloke/llama-2-7B-Guanaco-QLoRA-GGUF
There are multiple versions available, so choose the one that suits your device best. Once you've downloaded the model, decide where you want to place it. Remember to keep track of the path as you will need it later. As a bonus, I have two models for performance testing: one that consumes less RAM and another that requires more RAM.
 

Let's start with the medium-sized model. In the code, you'll need to specify the path and your prompt. The prompt serves as the instruction or explanation, and the shorter it is, the faster the code will run. Keep in mind that this may vary depending on the model you're using.
 
 

Feel free to modify these variables based on your requirements. If you notice that your PC is slowing down during the process, consider reducing the Context Size and GPU Layer Count. 
 
FUN FACT! You can customize the colors of your input and the displayed output, enhancing readability. For example, you can display prompts in yellow and white, and even change the color of the user input. I'll show you more as we progress through the code. 
 

There's a concept in the code where you control how truthful ChatGPT is, using a parameter called temperature. A temperature value of 0.5f is optimal, minimizing the likelihood of the model providing misleading, "lie-like" responses just to answer. Additionally, the use of AntiPrompts ensures that the model won't work unless the user provides input.
 
BONUS: Now comes the exciting part, the RUN! Here's the output:
 
Now, I'll ask it to create an HTML button with a black background and white text.
 

To ensure everything is working correctly, let's switch to VSCode or any online HTML compiler. Simply copy and paste the code, and click on 'Go Live' to see the result, or run it normally.
 

Result: 🎉
 

FUN FACT: THIS ARTICLE WAS ENHANCED BY CHATGPT! 😊
Github link for the Code : [Insert Github link here]

 

