# **Secret Santa Application**

This project is a **Secret Santa** application designed to facilitate gift exchange within a company, with a focus on creating a simple, user-friendly interface. The application allows employees to join or create a Secret Santa group, where each participant is randomly assigned someone to gift, ensuring that no one gifts themselves and everyone receives a gift.

## **Features**

- **User Interaction:**
  - **Create a Room:** Users can create a new Secret Santa room. Upon creation, they will receive a unique code to share with others.
  - **Join a Room:** Employees can join an existing room by entering the provided code.
  
- **Secret Santa Draw:**
  - Once everyone has joined, participants can press a button to perform a random draw. Each person is assigned another participant to gift, ensuring that no one receives themselves as their Secret Santa.
  
- **Wishlist Integration:**
  - Users can provide a "wishlist" of gift ideas. This list is linked to the user’s profile and can help other participants choose an appropriate gift.

## **How It Works**

1. **Creating a Room:**
   - The organizer enters their name and clicks to create a room. A unique code is generated that can be shared with other participants.
   
2. **Joining a Room:**
   - Users enter their name and the room code to join an existing Secret Santa group.
   
3. **Performing the Draw:**
   - Once all participants have joined, the organizer or any member can initiate the draw. Each participant is randomly matched with another person, and the list of gift assignments is private for each user.

4. **Wishlist:**
   - Participants can enter their gift preferences or suggestions, making the gift-giving process smoother and more personalized.

## **Key Considerations**

- **No Self-Gifting:** A participant cannot receive themselves as a Secret Santa.
- **Guaranteed Assignment:** Every participant will receive a match to gift, ensuring that no one is left without a recipient.
- **Simple Interface:** The application provides a simple, intuitive interface for both room creation and joining, making it easy for anyone to use.

## **Technologies Used**

- **C# & Windows Forms:** The project is built using C# with a Windows Forms interface, allowing for an interactive and accessible application.
- **Randomization Logic:** The application uses custom algorithms to ensure a fair and random Secret Santa assignment while adhering to the no-self-gifting rule.

## **Installation & Usage**

1. **Download the Repository**  
   Clone or download the project files to your local machine.

2. **Build the Project**  
   Open the solution in Visual Studio and build the project.

3. **Run the Application**  
   After building, run the project. The main menu will appear, allowing you to either create a new room or join an existing one by entering the provided code.

## **Future Improvements**

- **Database Integration:** Implement database support to save user profiles and room details for persistence across sessions.
- **Multi-Language Support:** Add support for multiple languages to accommodate diverse teams.
- **Notification System:** Introduce a system to notify participants about the results of the draw, reminders, and other updates.
