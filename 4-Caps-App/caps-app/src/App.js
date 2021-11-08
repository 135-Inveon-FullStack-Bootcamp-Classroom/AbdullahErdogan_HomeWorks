import "./App.css";
import CapsList from "./components/CapsList";
import { CapsProvider } from "./context/CapsContext";
function App() {
    return (
        <div className="App">
            <CapsProvider>
                <CapsList />
            </CapsProvider>
        </div>
    );
}

export default App;
