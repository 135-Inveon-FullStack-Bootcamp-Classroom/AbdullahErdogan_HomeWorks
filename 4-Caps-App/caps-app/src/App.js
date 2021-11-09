import "./App.css";
import CapsList from "./components/CapsList";
import { CapsProvider } from "./context/CapsContext";
import { BrowserRouter as Router, Route, Routes } from "react-router-dom";
import SingleCaps from "./components/SingleCaps";
function App() {
    return (
        <div className="App">
            <CapsProvider>
                <Router>
                    <Routes>
                        <Route path="/" element={<CapsList />} />
                        <Route
                            path="/single-caps/:id"
                            element={<SingleCaps />}
                        />
                    </Routes>
                </Router>
            </CapsProvider>
        </div>
    );
}

export default App;
